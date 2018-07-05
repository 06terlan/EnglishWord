namespace EnglishWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_loadin_wods = new System.Windows.Forms.PictureBox();
            this.lb_words = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_loading_info = new System.Windows.Forms.PictureBox();
            this.lbl_wrong_answer = new System.Windows.Forms.Label();
            this.lbl_correct_answer = new System.Windows.Forms.Label();
            this.lbl_means = new System.Windows.Forms.Label();
            this.lbl_word = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ask = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbn_next_word = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadin_wods)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading_info)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_loadin_wods);
            this.groupBox1.Controls.Add(this.lb_words);
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Words";
            // 
            // pb_loadin_wods
            // 
            this.pb_loadin_wods.BackColor = System.Drawing.Color.White;
            this.pb_loadin_wods.Image = global::EnglishWords.Properties.Resources.ajax_loader;
            this.pb_loadin_wods.Location = new System.Drawing.Point(138, 209);
            this.pb_loadin_wods.Name = "pb_loadin_wods";
            this.pb_loadin_wods.Size = new System.Drawing.Size(32, 32);
            this.pb_loadin_wods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_loadin_wods.TabIndex = 3;
            this.pb_loadin_wods.TabStop = false;
            this.pb_loadin_wods.Visible = false;
            // 
            // lb_words
            // 
            this.lb_words.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lb_words.FullRowSelect = true;
            this.lb_words.LabelWrap = false;
            this.lb_words.Location = new System.Drawing.Point(6, 23);
            this.lb_words.MultiSelect = false;
            this.lb_words.Name = "lb_words";
            this.lb_words.Size = new System.Drawing.Size(307, 465);
            this.lb_words.TabIndex = 5;
            this.lb_words.UseCompatibleStateImageBehavior = false;
            this.lb_words.View = System.Windows.Forms.View.Details;
            this.lb_words.SelectedIndexChanged += new System.EventHandler(this.lb_words_SelectedValueChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Word";
            this.columnHeader1.Width = 303;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_loading_info);
            this.groupBox2.Controls.Add(this.lbl_wrong_answer);
            this.groupBox2.Controls.Add(this.lbl_correct_answer);
            this.groupBox2.Controls.Add(this.lbl_means);
            this.groupBox2.Controls.Add(this.lbl_word);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(337, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // pb_loading_info
            // 
            this.pb_loading_info.BackColor = System.Drawing.Color.Transparent;
            this.pb_loading_info.Image = global::EnglishWords.Properties.Resources.ajax_loader;
            this.pb_loading_info.Location = new System.Drawing.Point(132, 47);
            this.pb_loading_info.Name = "pb_loading_info";
            this.pb_loading_info.Size = new System.Drawing.Size(32, 32);
            this.pb_loading_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_loading_info.TabIndex = 4;
            this.pb_loading_info.TabStop = false;
            this.pb_loading_info.Visible = false;
            // 
            // lbl_wrong_answer
            // 
            this.lbl_wrong_answer.AutoSize = true;
            this.lbl_wrong_answer.Location = new System.Drawing.Point(160, 91);
            this.lbl_wrong_answer.Name = "lbl_wrong_answer";
            this.lbl_wrong_answer.Size = new System.Drawing.Size(57, 22);
            this.lbl_wrong_answer.TabIndex = 7;
            this.lbl_wrong_answer.Text = "Word: ";
            // 
            // lbl_correct_answer
            // 
            this.lbl_correct_answer.AutoSize = true;
            this.lbl_correct_answer.Location = new System.Drawing.Point(160, 69);
            this.lbl_correct_answer.Name = "lbl_correct_answer";
            this.lbl_correct_answer.Size = new System.Drawing.Size(57, 22);
            this.lbl_correct_answer.TabIndex = 6;
            this.lbl_correct_answer.Text = "Word: ";
            // 
            // lbl_means
            // 
            this.lbl_means.AutoSize = true;
            this.lbl_means.Location = new System.Drawing.Point(160, 47);
            this.lbl_means.Name = "lbl_means";
            this.lbl_means.Size = new System.Drawing.Size(57, 22);
            this.lbl_means.TabIndex = 5;
            this.lbl_means.Text = "Word: ";
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Location = new System.Drawing.Point(160, 25);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(57, 22);
            this.lbl_word.TabIndex = 4;
            this.lbl_word.Text = "Word: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wrong answer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correct answer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Means: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word: ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ask);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(337, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btn_ask
            // 
            this.btn_ask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ask.ImageIndex = 5;
            this.btn_ask.ImageList = this.imageList1;
            this.btn_ask.Location = new System.Drawing.Point(10, 67);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(114, 33);
            this.btn_ask.TabIndex = 3;
            this.btn_ask.Text = "  Ask";
            this.btn_ask.UseVisualStyleBackColor = true;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "del.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "setting.png");
            this.imageList1.Images.SetKeyName(4, "word.png");
            this.imageList1.Images.SetKeyName(5, "ask.png");
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(252, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(10, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(132, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(337, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 71);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setting";
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(10, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Setting";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbn_next_word);
            this.groupBox5.Location = new System.Drawing.Point(337, 329);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Word";
            // 
            // tbn_next_word
            // 
            this.tbn_next_word.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbn_next_word.ImageIndex = 4;
            this.tbn_next_word.ImageList = this.imageList1;
            this.tbn_next_word.Location = new System.Drawing.Point(10, 28);
            this.tbn_next_word.Name = "tbn_next_word";
            this.tbn_next_word.Size = new System.Drawing.Size(154, 33);
            this.tbn_next_word.TabIndex = 4;
            this.tbn_next_word.Text = "Next word";
            this.tbn_next_word.UseVisualStyleBackColor = true;
            this.tbn_next_word.Click += new System.EventHandler(this.tbn_next_word_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(724, 505);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EnglishWords v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loadin_wods)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading_info)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_wrong_answer;
        private System.Windows.Forms.Label lbl_correct_answer;
        private System.Windows.Forms.Label lbl_means;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb_loadin_wods;
        private System.Windows.Forms.PictureBox pb_loading_info;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button tbn_next_word;
        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.ListView lb_words;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

