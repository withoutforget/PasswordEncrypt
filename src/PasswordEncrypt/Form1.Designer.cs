namespace PasswordEncrypt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.status_box = new System.Windows.Forms.GroupBox();
            this.status_buffer = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save_file_button = new MetroFramework.Controls.MetroButton();
            this.load_file_button = new MetroFramework.Controls.MetroButton();
            this.file_key = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.file_path = new MetroFramework.Controls.MetroTextBox();
            this.open_file_button = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove_password = new MetroFramework.Controls.MetroButton();
            this.save_password = new MetroFramework.Controls.MetroButton();
            this.add_password = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.comment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.service = new MetroFramework.Controls.MetroTextBox();
            this.passwords = new System.Windows.Forms.ListBox();
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.status_box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_box
            // 
            this.status_box.Controls.Add(this.status_buffer);
            this.status_box.Location = new System.Drawing.Point(12, 333);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(776, 115);
            this.status_box.TabIndex = 0;
            this.status_box.TabStop = false;
            this.status_box.Text = "Logs";
            // 
            // status_buffer
            // 
            this.status_buffer.Location = new System.Drawing.Point(7, 20);
            this.status_buffer.Multiline = true;
            this.status_buffer.Name = "status_buffer";
            this.status_buffer.ReadOnly = true;
            this.status_buffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status_buffer.Size = new System.Drawing.Size(763, 74);
            this.status_buffer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save_file_button);
            this.groupBox1.Controls.Add(this.load_file_button);
            this.groupBox1.Controls.Add(this.file_key);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.file_path);
            this.groupBox1.Controls.Add(this.open_file_button);
            this.groupBox1.Location = new System.Drawing.Point(588, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // save_file_button
            // 
            this.save_file_button.Location = new System.Drawing.Point(6, 109);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(75, 23);
            this.save_file_button.TabIndex = 6;
            this.save_file_button.Text = "save";
            this.save_file_button.Click += new System.EventHandler(this.save_file_button_Click);
            // 
            // load_file_button
            // 
            this.load_file_button.Location = new System.Drawing.Point(6, 80);
            this.load_file_button.Name = "load_file_button";
            this.load_file_button.Size = new System.Drawing.Size(75, 23);
            this.load_file_button.TabIndex = 5;
            this.load_file_button.Text = "load";
            this.load_file_button.Click += new System.EventHandler(this.load_file_button_Click);
            // 
            // file_key
            // 
            this.file_key.Location = new System.Drawing.Point(47, 51);
            this.file_key.Name = "file_key";
            this.file_key.Size = new System.Drawing.Size(141, 23);
            this.file_key.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(28, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "key";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "path";
            // 
            // file_path
            // 
            this.file_path.Location = new System.Drawing.Point(47, 21);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(141, 23);
            this.file_path.TabIndex = 1;
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(87, 80);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(75, 23);
            this.open_file_button.TabIndex = 0;
            this.open_file_button.Text = "Open";
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remove_password);
            this.groupBox2.Controls.Add(this.save_password);
            this.groupBox2.Controls.Add(this.add_password);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.comment);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.login);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.service);
            this.groupBox2.Controls.Add(this.passwords);
            this.groupBox2.Location = new System.Drawing.Point(19, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 263);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passwords";
            // 
            // remove_password
            // 
            this.remove_password.Location = new System.Drawing.Point(295, 222);
            this.remove_password.Name = "remove_password";
            this.remove_password.Size = new System.Drawing.Size(75, 23);
            this.remove_password.TabIndex = 11;
            this.remove_password.Text = "Remove";
            this.remove_password.Click += new System.EventHandler(this.remove_password_Click);
            // 
            // save_password
            // 
            this.save_password.Location = new System.Drawing.Point(214, 222);
            this.save_password.Name = "save_password";
            this.save_password.Size = new System.Drawing.Size(75, 23);
            this.save_password.TabIndex = 10;
            this.save_password.Text = "Save";
            this.save_password.Click += new System.EventHandler(this.save_password_Click);
            // 
            // add_password
            // 
            this.add_password.Location = new System.Drawing.Point(133, 222);
            this.add_password.Name = "add_password";
            this.add_password.Size = new System.Drawing.Size(75, 23);
            this.add_password.TabIndex = 9;
            this.add_password.Text = "Add";
            this.add_password.Click += new System.EventHandler(this.add_password_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(134, 107);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "comment";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(202, 107);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(315, 76);
            this.comment.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(134, 78);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "password";
            this.metroLabel5.DoubleClick += new System.EventHandler(this.metroLabel5_DoubleClick);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(202, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(315, 23);
            this.password.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(134, 52);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "login";
            this.metroLabel4.DoubleClick += new System.EventHandler(this.metroLabel4_DoubleClick);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(202, 49);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login.Size = new System.Drawing.Size(315, 23);
            this.login.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(134, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "service";
            this.metroLabel3.DoubleClick += new System.EventHandler(this.metroLabel3_DoubleClick);
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(202, 20);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(315, 23);
            this.service.TabIndex = 1;
            // 
            // passwords
            // 
            this.passwords.FormattingEnabled = true;
            this.passwords.Location = new System.Drawing.Point(7, 20);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(120, 225);
            this.passwords.TabIndex = 0;
            this.passwords.SelectedIndexChanged += new System.EventHandler(this.passwords_SelectedIndexChanged);
            // 
            // file_dialog
            // 
            this.file_dialog.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(713, 34);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Settings";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status_box);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PasswordEncrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.status_box.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox status_box;
        private MetroFramework.Controls.MetroTextBox status_buffer;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton open_file_button;
        private MetroFramework.Controls.MetroTextBox file_key;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox file_path;
        private MetroFramework.Controls.MetroButton save_file_button;
        private MetroFramework.Controls.MetroButton load_file_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox service;
        private System.Windows.Forms.ListBox passwords;
        private MetroFramework.Controls.MetroButton remove_password;
        private MetroFramework.Controls.MetroButton save_password;
        private MetroFramework.Controls.MetroTextBox comment;
        private MetroFramework.Controls.MetroButton add_password;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

