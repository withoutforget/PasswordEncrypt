using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace PasswordEncrypt
{
    public class Settings
    {
        public Settings() {
        }

        public void init()
        {
            if (!Directory.Exists(file_folder))
            {
                Directory.CreateDirectory(file_folder);
                File.WriteAllText(Path.Combine(file_folder, file_name), JsonSerializer.Serialize(this));
            }
            else
            {
                Settings cp = JsonSerializer.Deserialize<Settings>(File.ReadAllText(Path.Combine(file_folder, file_name)));
                color_style = cp.color_style;
                file_folder = cp.file_folder;
                file_name = cp.file_name;
                last_opened_file = cp.last_opened_file;
            }
        }

        public void update()
        {
            File.WriteAllText(Path.Combine(file_folder, file_name), JsonSerializer.Serialize(this));
        }

        public MetroFramework.MetroColorStyle color_style { get; set; } = MetroFramework.MetroColorStyle.Purple;
        public string last_opened_file { get; set; }

        public string file_folder { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/_passwordencrypt/";
        public string file_name { get; set; } = "settings.json";
    }
}
