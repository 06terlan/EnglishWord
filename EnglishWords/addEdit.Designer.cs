namespace EnglishWords
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.tb_means = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word: ";
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
            // tb_word
            // 
            this.tb_word.Location = new System.Drawing.Point(75, 6);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(390, 29);
            this.tb_word.TabIndex = 2;
            // 
            // tb_means
            // 
            this.tb_means.Location = new System.Drawing.Point(75, 44);
            this.tb_means.Name = "tb_means";
            this.tb_means.Size = new System.Drawing.Size(390, 29);
            this.tb_means.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(282, 79);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 33);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "save.png");
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImageKey = "close.png";
            this.btn_close.ImageList = this.imageList1;
            this.btn_close.Location = new System.Drawing.Point(376, 79);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 33);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "  Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Add
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(477, 117);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_means);
            this.Controls.Add(this.tb_word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEdit";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.TextBox tb_means;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ImageList imageList1;
    }
}