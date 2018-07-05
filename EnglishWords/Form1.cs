using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishWords
{
    
    
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            notifyIcon1.BalloonTipText = "Still working...";
            notifyIcon1.BalloonTipTitle = "EnglishWords";

            if (args.Length > 0 && args[0] == "-minimized") this.args = args[0];
        }

        static string DataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)+"\\EnglishWords";
        static string wordsFileDir = DataPath + "\\word.xml";
        static string settingFileDir = DataPath + "\\setting.xml";
        int min = 5,ticked = 0;
        xmlDataM xmlDatam;
        string args = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (args == "-minimized") this.WindowState = FormWindowState.Minimized;

            lbl_correct_answer.Text = "-";
            lbl_means.Text = "-";
            lbl_word.Text = "-";
            lbl_wrong_answer.Text = "-";

            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(0, new MenuItem("Open",new EventHandler(menu_Open)));
            menu.MenuItems.Add(1, new MenuItem("Exit", new EventHandler(menu_Exit)));
            notifyIcon1.ContextMenu = menu;

            checkFiles();

            xmlDatam = new xmlDataM(wordsFileDir);
            int.TryParse(new xmlDataM(settingFileDir).Doc().Element("settings").Element("timeout").Value,out min);
            timer1.Start();

            getData();            
        }

        private void Form1_EAnswered()
        {
            MessageBox.Show("Ansver");
            timer1.Start();
        }

        private void checkFiles()
        {
            if (!Directory.Exists(DataPath)) Directory.CreateDirectory(DataPath);
            if (!System.IO.File.Exists(wordsFileDir)) System.IO.File.WriteAllText(wordsFileDir, Properties.Resources.words);
            if (!System.IO.File.Exists(settingFileDir)) System.IO.File.WriteAllText(settingFileDir, Properties.Resources.setting);
        }

        private void getData()
        {
            pb_loadin_wods.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            lb_words.Items.Clear();

            Thread tt = new Thread(() =>
            {
                //this.Invoke(new MethodInvoker(delegate () { selectedFile = cb_logs.Text; }));
                foreach (var coordinate in xmlDatam.Doc().Descendants("word"))
                {
                    string text = coordinate.Attribute("text").Value;
                    this.Invoke(new MethodInvoker(delegate () 
                        {
                            lb_words.Items.Add(text);
                            lb_words.Items[lb_words.Items.Count - 1].BackColor = coordinate.Element("ask").Value == "1" ? Color.White : Color.Yellow;
                        }));
                }

                this.Invoke(new MethodInvoker(delegate () 
                    {
                        pb_loadin_wods.Visible = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }));
            });
            tt.IsBackground = true;
            tt.Start();          
        }

        Thread getInfoT = null;
        XElement selectedData = null;
        private void getInfo()
        {
            string txt = lb_words.SelectedItems[0].Text;
            pb_loading_info.Visible = true;
            if (getInfoT != null && getInfoT.IsAlive)
                getInfoT.Abort();

            getInfoT = new Thread(() => 
            {
                selectedData = xmlDatam.Doc().Root.Descendants("word").Where(x => x.Attribute("text").Value == txt).First();
                this.Invoke(new MethodInvoker(delegate ()
                {
                    lbl_correct_answer.Text = selectedData.Element("c_answer").Value;
                    lbl_means.Text = selectedData.Element("means").Value;
                    lbl_word.Text = txt;
                    lbl_wrong_answer.Text = selectedData.Element("w_answer").Value;
                    btn_ask.Text = selectedData.Element("ask").Value == "1" ? "    Don't ask" : "  Ask";
                    pb_loading_info.Visible = false;
                }));
            });
            getInfoT.IsBackground = true;
            getInfoT.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menu_Open(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menu_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add ff = new Add();
            ff.text = "";
            ff.path = wordsFileDir;
            ff.ShowDialog();
            xmlDatam.reDoc();
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_words.SelectedItems.Count>0)
            {
                DialogResult dd = MessageBox.Show("Are you sure?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dd == DialogResult.Yes)
                {
                    string text = lb_words.SelectedItems[0].Text;
                    xmlDatam.Doc().Descendants("word").Where(x => x.Attribute("text").Value == text).Remove();
                    xmlDatam.Save();
                    getData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb_words.SelectedItems.Count>0)
            {
                Add ff = new Add();
                ff.text = lb_words.SelectedItems[0].Text;
                ff.path = wordsFileDir;
                ff.ShowDialog();
                xmlDatam.reDoc();
                getData();
            }
        }

        private void lb_words_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb_words.SelectedItems.Count>0)
            {
                getInfo();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FSetting ff = new FSetting();
            ff.path = settingFileDir;
            ff.pathData = wordsFileDir;
            ff.ShowDialog();
        }

        private void tbn_next_word_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FQuestion ff = new FQuestion(() => { timer1.Start(); xmlDatam.reDoc(); });
            ff.path = wordsFileDir;
            ff.Show();
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            if (selectedData != null)
            {
                if (selectedData.Element("ask").Value == "1")
                {
                    selectedData.Element("ask").Value = "0";
                    lb_words.SelectedItems[0].BackColor = Color.Yellow;
                }
                else
                {
                    selectedData.Element("ask").Value = "1";
                    lb_words.SelectedItems[0].BackColor = Color.White;
                }
                xmlDatam.Save();
                xmlDatam.reDoc();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticked++;
            if (ticked == min)
            {
                ticked = 0;
                timer1.Stop();
                FQuestion ff = new FQuestion(()=> { timer1.Start(); xmlDatam.reDoc(); });
                ff.path = wordsFileDir;
                ff.Show();
            }
        }
    }    
}
