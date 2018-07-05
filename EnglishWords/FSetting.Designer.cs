namespace EnglishWords
{
    partial class FSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time (min): ";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(111, 19);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(161, 29);
            this.tb_min.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImageKey = "close.png";
            this.btn_close.ImageList = this.imageList1;
            this.btn_close.Location = new System.Drawing.Point(182, 146);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 33);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "  Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "save.png");
            // 
            // btn_save
            // 
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(88, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 33);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Auto open: ";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.Location = new System.Drawing.Point(111, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.Location = new System.Drawing.Point(191, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Del";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clear w/c: ";
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 1;
            this.button3.Location = new System.Drawing.Point(111, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FSetting
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(299, 191);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}