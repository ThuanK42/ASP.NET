namespace Dialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picOpenFile = new System.Windows.Forms.PictureBox();
            this.btnChon1Hinh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.rtbLuu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDoiMau = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDoiFont = new System.Windows.Forms.Button();
            this.lblDoiFont = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChonThuMuc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picOpenFile);
            this.tabPage1.Controls.Add(this.btnChon1Hinh);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OpenFile Dialog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picOpenFile
            // 
            this.picOpenFile.Location = new System.Drawing.Point(28, 168);
            this.picOpenFile.Name = "picOpenFile";
            this.picOpenFile.Size = new System.Drawing.Size(378, 199);
            this.picOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenFile.TabIndex = 1;
            this.picOpenFile.TabStop = false;
            // 
            // btnChon1Hinh
            // 
            this.btnChon1Hinh.Location = new System.Drawing.Point(39, 22);
            this.btnChon1Hinh.Name = "btnChon1Hinh";
            this.btnChon1Hinh.Size = new System.Drawing.Size(242, 58);
            this.btnChon1Hinh.TabIndex = 0;
            this.btnChon1Hinh.Text = "Chọn 1 hình";
            this.btnChon1Hinh.UseVisualStyleBackColor = true;
            this.btnChon1Hinh.Click += new System.EventHandler(this.btnChon1Hinh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLuu);
            this.tabPage2.Controls.Add(this.rtbLuu);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SaveFile Dialog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(34, 295);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // rtbLuu
            // 
            this.rtbLuu.Location = new System.Drawing.Point(34, 68);
            this.rtbLuu.Name = "rtbLuu";
            this.rtbLuu.Size = new System.Drawing.Size(521, 193);
            this.rtbLuu.TabIndex = 1;
            this.rtbLuu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập nội dung";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDoiMau);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color Dialog";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDoiMau
            // 
            this.btnDoiMau.Location = new System.Drawing.Point(98, 83);
            this.btnDoiMau.Name = "btnDoiMau";
            this.btnDoiMau.Size = new System.Drawing.Size(548, 250);
            this.btnDoiMau.TabIndex = 0;
            this.btnDoiMau.Text = "Bay màu nhớ";
            this.btnDoiMau.UseVisualStyleBackColor = true;
            this.btnDoiMau.Click += new System.EventHandler(this.btnDoiMau_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDoiFont);
            this.tabPage4.Controls.Add(this.lblDoiFont);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Font Dialog";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDoiFont
            // 
            this.btnDoiFont.Location = new System.Drawing.Point(202, 254);
            this.btnDoiFont.Name = "btnDoiFont";
            this.btnDoiFont.Size = new System.Drawing.Size(234, 75);
            this.btnDoiFont.TabIndex = 1;
            this.btnDoiFont.Text = "Đổi font chữ nào";
            this.btnDoiFont.UseVisualStyleBackColor = true;
            this.btnDoiFont.Click += new System.EventHandler(this.btnDoiFont_Click);
            // 
            // lblDoiFont
            // 
            this.lblDoiFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiFont.Location = new System.Drawing.Point(155, 41);
            this.lblDoiFont.Name = "lblDoiFont";
            this.lblDoiFont.Size = new System.Drawing.Size(429, 121);
            this.lblDoiFont.TabIndex = 0;
            this.lblDoiFont.Text = "Thuận Thiên Ý";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSave);
            this.tabPage5.Controls.Add(this.btnChonThuMuc);
            this.tabPage5.Controls.Add(this.txtPath);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "FolderBrowser Dialog";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập nội dung";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(708, 149);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn nơi giấu";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(14, 260);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(660, 22);
            this.txtPath.TabIndex = 3;
            // 
            // btnChonThuMuc
            // 
            this.btnChonThuMuc.Location = new System.Drawing.Point(680, 258);
            this.btnChonThuMuc.Name = "btnChonThuMuc";
            this.btnChonThuMuc.Size = new System.Drawing.Size(38, 23);
            this.btnChonThuMuc.TabIndex = 4;
            this.btnChonThuMuc.Text = "...";
            this.btnChonThuMuc.UseVisualStyleBackColor = true;
            this.btnChonThuMuc.Click += new System.EventHandler(this.btnChonThuMuc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 54);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picOpenFile;
        private System.Windows.Forms.Button btnChon1Hinh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.RichTextBox rtbLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDoiMau;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDoiFont;
        private System.Windows.Forms.Label lblDoiFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChonThuMuc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

