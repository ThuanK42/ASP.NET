namespace BaiTapCoBanSQL
{
    partial class GetData
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
            this.btnDem = new System.Windows.Forms.Button();
            this.lbSoSanPham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP2 = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnXemChiTiet2 = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.lvDSSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDem
            // 
            this.btnDem.Location = new System.Drawing.Point(83, 51);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(173, 86);
            this.btnDem.TabIndex = 0;
            this.btnDem.Text = "Đếm số sản phẩm";
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // lbSoSanPham
            // 
            this.lbSoSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoSanPham.Location = new System.Drawing.Point(409, 67);
            this.lbSoSanPham.Name = "lbSoSanPham";
            this.lbSoSanPham.Size = new System.Drawing.Size(246, 70);
            this.lbSoSanPham.TabIndex = 1;
            this.lbSoSanPham.Text = "label1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(80, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã sp";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(171, 181);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(158, 22);
            this.txtMaSp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(80, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "tên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(80, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "giá";
            // 
            // txtMaSP2
            // 
            this.txtMaSP2.Location = new System.Drawing.Point(156, 317);
            this.txtMaSP2.Name = "txtMaSP2";
            this.txtMaSP2.Size = new System.Drawing.Size(158, 22);
            this.txtMaSP2.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(156, 364);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(158, 22);
            this.txtTen.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(156, 399);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(158, 22);
            this.txtGia.TabIndex = 4;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(83, 241);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(185, 47);
            this.btnXemChiTiet.TabIndex = 5;
            this.btnXemChiTiet.Text = "Xem chi tiết Sp";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnXemChiTiet2
            // 
            this.btnXemChiTiet2.Location = new System.Drawing.Point(297, 241);
            this.btnXemChiTiet2.Name = "btnXemChiTiet2";
            this.btnXemChiTiet2.Size = new System.Drawing.Size(189, 47);
            this.btnXemChiTiet2.TabIndex = 6;
            this.btnXemChiTiet2.Text = "Xem CT dùng parameter";
            this.btnXemChiTiet2.UseVisualStyleBackColor = true;
            this.btnXemChiTiet2.Click += new System.EventHandler(this.btnXemChiTiet2_Click);
            // 
            // btnDS
            // 
            this.btnDS.Location = new System.Drawing.Point(613, 51);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(264, 51);
            this.btnDS.TabIndex = 7;
            this.btnDS.Text = "Hiển thị DSSP";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // lvDSSP
            // 
            this.lvDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDSSP.FullRowSelect = true;
            this.lvDSSP.GridLines = true;
            this.lvDSSP.HideSelection = false;
            this.lvDSSP.Location = new System.Drawing.Point(566, 141);
            this.lvDSSP.Name = "lvDSSP";
            this.lvDSSP.Size = new System.Drawing.Size(429, 163);
            this.lvDSSP.TabIndex = 8;
            this.lvDSSP.UseCompatibleStateImageBehavior = false;
            this.lvDSSP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 96;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 516);
            this.Controls.Add(this.lvDSSP);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnXemChiTiet2);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.txtMaSP2);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaSp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSoSanPham);
            this.Controls.Add(this.btnDem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Label lbSoSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnXemChiTiet2;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.ListView lvDSSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

