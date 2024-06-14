using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PasswordEncrypt;
using System.Text.Json;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;

namespace PasswordEncrypt
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            m_settings = new Settings();
            m_settings.init();
        }

        public Settings m_settings;

        private List<Password> passwordList = new List<Password>();

        private void append_buffer(string str)
        {
            if (status_buffer.Text.Length > 0)
                status_buffer.Text = str + "\r\n" + status_buffer.Text;
            else
                status_buffer.Text += str + "\r\n"; 
        }

        public static string EncryptString(string plainText, string keyString)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = GetKey(keyString);
                aes.Mode = CipherMode.CBC;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string cipherText, string keyString)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = GetKey(keyString);
                aes.Mode = CipherMode.CBC;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private static byte[] GetKey(string keyString)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(keyString));
                byte[] keyBytes = new byte[32];
                Array.Copy(keyHash, keyBytes, keyBytes.Length);
                return keyBytes;
            }
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            DialogResult = file_dialog.ShowDialog();
            if (DialogResult != DialogResult.OK)
            {
                append_buffer("Have not selected file");
            }
            else
            {
                file_path.Text = file_dialog.FileName;
                append_buffer($"Opened file '{file_dialog.FileName}'");
            }
        }

        private void add_password_Click(object sender, EventArgs e)
        {
            passwordList.Add(new Password(service.Text, login.Text, password.Text, comment.Text));
            passwords.Items.Add($"{service.Text} {login.Text}");
            append_buffer("Successfully saved data");
        }

        private void passwords_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = passwords.SelectedIndex;
            if (idx == -1) return;
            Password pwd = passwordList[idx];
            service.Text = pwd.service;
            login.Text = pwd.login;
            password.Text = pwd.password; 
            comment.Text = pwd.comment;
            append_buffer("Selected");
        }

        private void remove_password_Click(object sender, EventArgs e)
        {
            var idx = passwords.SelectedIndices;
            if (idx.Count == 0 && DialogResult.OK != MessageBox.Show($"Do you want to delete {idx.Count} items?")) return;
            foreach (var el in idx)
            {
                passwords.Items.RemoveAt((int)el);
                passwordList.RemoveAt((int)el);
            }
            append_buffer("password removed");
        }

        private void save_password_Click(object sender, EventArgs e)
        {
            var idx = passwords.SelectedIndex;
            if (idx == -1) return;
            Password pwd = new Password(service.Text, login.Text, password.Text, comment.Text);
            passwordList[idx] = pwd;
            passwords.Items[idx] = $"{service.Text} {login.Text}";
            append_buffer("Data saved");
        }

        private void save_file_button_Click(object sender, EventArgs e)
        {
            if (file_path.Text.Length == 0)
            {
                append_buffer("Cannot save to empty path");
                return;
            }
            string jsonString = JsonSerializer.Serialize(passwordList);
            string encrypted = EncryptString(jsonString, file_key.Text);
            File.WriteAllText(file_path.Text, encrypted);
        }

        private void load_file_button_Click(object sender, EventArgs e)
        {
            if (file_path.Text.Length == 0)
            {
                append_buffer("Can't open empty path");
                return;
            }
            passwordList.Clear();
            passwords.Items.Clear();
            string encrypted = File.ReadAllText(file_path.Text);
            try
            {
                string json_env = DecryptString(encrypted, file_key.Text);
                passwordList = JsonSerializer.Deserialize<List<Password>>(json_env);
                foreach (var pwd in passwordList)
                    passwords.Items.Add($"{pwd.service} {pwd.login}");
                append_buffer($"successfully opened file '{file_path.Text}'");
                m_settings.last_opened_file = file_path.Text;
                m_settings.update();
            }
            catch (Exception)
            {
                append_buffer("Cannot open file due to wrong key");
            }
        }
     

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm(m_settings);
            var dialog_result = settings.ShowDialog();
            if (dialog_result == DialogResult.OK)
            {
                this.Style = settings.m_style;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Style = m_settings.color_style;
            this.file_path.Text = m_settings.last_opened_file;
            file_dialog.InitialDirectory = m_settings.file_folder;
        }

        private void metroLabel3_DoubleClick(object sender, EventArgs e)
        {
            if (service.Text.Length == 0) return;
            Clipboard.SetText(service.Text);
            append_buffer("service copied to clibboard");
        }

        private void metroLabel4_DoubleClick(object sender, EventArgs e)
        {
            if (login.Text.Length == 0) return;
            Clipboard.SetText(login.Text);
            append_buffer("login copied to clibboard");
        }

        private void metroLabel5_DoubleClick(object sender, EventArgs e)
        {
            if (password.Text.Length == 0) return;
            Clipboard.SetText(password.Text);
            append_buffer("password copied to clibboard");
        }
    }
}
