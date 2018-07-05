namespace EnglishWords
{
    partial class FQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_word = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Location = new System.Drawing.Point(83, 16);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(15, 22);
            this.lbl_word.TabIndex = 1;
            this.lbl_word.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer:";
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(87, 41);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(266, 29);
            this.tb_answer.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(87, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "    Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ok.png");
            // 
            // FQuestion
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(367, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FQuestion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FQuestion_FormClosing);
            this.Load += new System.EventHandler(this.FQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
    }
}