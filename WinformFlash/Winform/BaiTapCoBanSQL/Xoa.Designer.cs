namespace BaiTapCoBanSQL
{
    partial class Xoa
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
            this.lsbSanPham = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbSanPham
            // 
            this.lsbSanPham.FormattingEnabled = true;
            this.lsbSanPham.ItemHeight = 16;
            this.lsbSanPham.Location = new System.Drawing.Point(55, 53);
            this.lsbSanPham.Name = "lsbSanPham";
            this.lsbSanPham.Size = new System.Drawing.Size(309, 388);
            this.lsbSanPham.TabIndex = 0;
             
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(55, 462);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 46);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(227, 462);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(120, 46);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xoa Parameter";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // Xoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lsbSanPham);
            this.Name = "Xoa";
            this.Text = "Xoa";
            this.Load += new System.EventHandler(this.Xoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaCT;
    }
}