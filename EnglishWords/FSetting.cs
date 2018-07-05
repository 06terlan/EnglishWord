using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishWords
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
        }

        public string path;
        public string pathData;
        xmlDataM xmlDatam;
        private void FSetting_Load(object sender, EventArgs e)
        {
            xmlDatam = new xmlDataM(path);

            tb_min.Text = xmlDatam.Doc().Element("settings").Element("timeout").Value;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int min;
            if (int.TryParse(tb_min.Text, out min) && min > 0)
            {
                xmlDatam.Doc().Element("settings").Element("timeout").Value = min.ToString();
                xmlDatam.Save();
                this.Close();
            }
            else MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey startapp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            startapp.SetValue("EnglishWords", Application.ExecutablePath.ToString() + " -minimized");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey startapp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);            
            if(startapp.GetValue("EnglishWords")!=null) startapp.DeleteValue("EnglishWords");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                xmlDataM data = new xmlDataM(pathData);
                IEnumerable<XElement> elements = data.Doc().Descendants("word");
                foreach (XElement coordinate in elements)
                {
                    coordinate.SetElementValue("w_answer","0");
                    coordinate.SetElementValue("c_answer", "0");
                }
                data.Save();
            }
            
        }
    }
}
