using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordEncrypt
{
    public partial class SettingsForm : MetroForm
    {

        public SettingsForm(Settings settings)
        {
            m_settings = settings;
            InitializeComponent();
        }

        public MetroFramework.MetroColorStyle m_style = MetroFramework.MetroColorStyle.Lime;
        public Settings m_settings;

        private void Settings_Load(object sender, EventArgs e)
        {
            string[] colors = Enum.GetNames(typeof(MetroFramework.MetroColorStyle));
            metroComboBox1.Items.AddRange(colors);
            metroComboBox1.SelectedIndex = (int)m_settings.color_style;
            this.Style = m_settings.color_style;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Style = (MetroFramework.MetroColorStyle)Enum.Parse(typeof(MetroFramework.MetroColorStyle), metroComboBox1.Text);
            m_settings.color_style = this.Style;
            m_settings.update();
            m_style = this.Style;
            DialogResult = DialogResult.OK;
        }
    }
}
