using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishWords
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        public string text = "";
        public string path = "";
        public string word = "",means = "";
        private xmlDataM xmlDataM;

        private void Add_Load(object sender, EventArgs e)
        {
            xmlDataM = new xmlDataM(path);
            if (text != "")
            {
                var data = xmlDataM.Doc().Root.Descendants("word").Where(x => x.Attribute("text").Value == text).Elements("means").ToArray();
                if (data.Count() > 0)
                {
                    means = data[0].Value;
                    tb_word.Text = text;
                    tb_means.Text = means;
                }
                else this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {            
            word = tb_word.Text.Trim().ToLower();
            means = tb_means.Text.Trim();

            var data = xmlDataM.Doc().Root.Descendants("word").Where(x => x.Attribute("text").Value == word).Descendants().ToList();

            if (word != "" && means != "" && ((text == "" && data.Count()==0) || (text != "")))
            {
                if (text == "")
                {
                    var newElement = new XElement("word"
                                    , new XAttribute("text", word)
                                    , new XElement("means", means)
                                    , new XElement("c_answer", "0")
                                    , new XElement("w_answer", "0")
                                    , new XElement("ask", "1"));

                    xmlDataM.Add(newElement, "words");
                }
                else
                {
                    var ddd = xmlDataM.Doc().Root.Descendants("word").Where(x => x.Attribute("text").Value == text).Single();
                    ddd.Element("means").Value = means;
                    ddd.Attribute("text").Value = word;
                    xmlDataM.Save();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
