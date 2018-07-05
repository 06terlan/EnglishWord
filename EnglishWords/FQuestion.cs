using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishWords
{
    public partial class FQuestion : Form
    {
        public FQuestion(Action calback)
        {
            InitializeComponent();
            this.calback = calback;
        }

        public string path;
        Action calback;
        private xmlDataM xmlDatam;
        XElement data;

        private void FQuestion_Load(object sender, EventArgs e)
        {
            xmlDatam = new xmlDataM(path);
            data = (xmlDatam.Doc().Descendants("word")
                        .Where(x => x.Element("ask").Value=="1")
                        .OrderBy(r => (int.Parse(r.Element("c_answer").Value) - int.Parse(r.Element("w_answer").Value))))
                        .First();

            lbl_word.Text = data.Attribute("text").Value;
            tb_answer.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vv = 0;
            if (tb_answer.Text.Trim().ToLower() == data.Element("means").Value.ToLower())
            {
                vv = int.Parse(data.Element("c_answer").Value) + 1;
                data.Element("c_answer").Value = vv.ToString();
                MessageBox.Show("Correct answer: " + vv +" Wrong answer: "+ data.Element("w_answer").Value, "Correct", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                vv = int.Parse(data.Element("w_answer").Value) + 1;
                data.Element("w_answer").Value = vv.ToString();
                MessageBox.Show("Correct answer: " + data.Element("c_answer").Value + " Wrong answer: " + vv+" Answer: "+ data.Element("means").Value, "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            xmlDatam.Save();
            calback();
            this.Close();            
        }

        private void FQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            calback();
        }
    }
}
