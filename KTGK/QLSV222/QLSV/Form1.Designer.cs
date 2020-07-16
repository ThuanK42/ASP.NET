namespace QLSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttensinhvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datenamsinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radionam = new System.Windows.Forms.RadioButton();
            this.radionu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxmonhoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxsothich = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.dataGridSinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên";
            // 
            // txttensinhvien
            // 
            this.txttensinhvien.Location = new System.Drawing.Point(176, 29);
            this.txttensinhvien.Name = "txttensinhvien";
            this.txttensinhvien.Size = new System.Drawing.Size(187, 20);
            this.txttensinhvien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm sinh";
            // 
            // datenamsinh
            // 
            this.datenamsinh.Location = new System.Drawing.Point(176, 57);
            this.datenamsinh.Name = "datenamsinh";
            this.datenamsinh.Size = new System.Drawing.Size(200, 20);
            this.datenamsinh.TabIndex = 3;
            this.datenamsinh.ValueChanged += new System.EventHandler(this.datenamsinh_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // radionam
            // 
            this.radionam.AutoSize = true;
            this.radionam.Location = new System.Drawing.Point(176, 93);
            this.radionam.Name = "radionam";
            this.radionam.Size = new System.Drawing.Size(47, 17);
            this.radionam.TabIndex = 5;
            this.radionam.TabStop = true;
            this.radionam.Text = "Nam";
            this.radionam.UseVisualStyleBackColor = true;
            this.radionam.Click += new System.EventHandler(this.radionam_Click);
            // 
            // radionu
            // 
            this.radionu.AutoSize = true;
            this.radionu.Location = new System.Drawing.Point(267, 93);
            this.radionu.Name = "radionu";
            this.radionu.Size = new System.Drawing.Size(39, 17);
            this.radionu.TabIndex = 6;
            this.radionu.TabStop = true;
            this.radionu.Text = "Nữ";
            this.radionu.UseVisualStyleBackColor = true;
            this.radionu.Click += new System.EventHandler(this.radionu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn học";
            // 
            // comboBoxmonhoc
            // 
            this.comboBoxmonhoc.FormattingEnabled = true;
            this.comboBoxmonhoc.Location = new System.Drawing.Point(176, 120);
            this.comboBoxmonhoc.Name = "comboBoxmonhoc";
            this.comboBoxmonhoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxmonhoc.TabIndex = 8;
            this.comboBoxmonhoc.SelectedValueChanged += new System.EventHandler(this.comboBoxmonhoc_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sở thích";
            // 
            // checkedListBoxsothich
            // 
            this.checkedListBoxsothich.FormattingEnabled = true;
            this.checkedListBoxsothich.Items.AddRange(new object[] {
            "Đá Bóng",
            "Chơi Game",
            "Xem Phim"});
            this.checkedListBoxsothich.Location = new System.Drawing.Point(176, 147);
            this.checkedListBoxsothich.Name = "checkedListBoxsothich";
            this.checkedListBoxsothich.Size = new System.Drawing.Size(82, 49);
            this.checkedListBoxsothich.TabIndex = 10;
            this.checkedListBoxsothich.SelectedValueChanged += new System.EventHandler(this.checkedListBoxsothich_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(423, 93);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(318, 86);
            this.txtghichu.TabIndex = 12;
            // 
            // dataGridSinhVien
            // 
            this.dataGridSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSinhVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridSinhVien.Location = new System.Drawing.Point(0, 244);
            this.dataGridSinhVien.Name = "dataGridSinhVien";
            this.dataGridSinhVien.Size = new System.Drawing.Size(843, 190);
            this.dataGridSinhVien.TabIndex = 13;
            this.dataGridSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSinhVien_CellClick);
            this.dataGridSinhVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSinhVien_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tensinhvien";
            this.Column1.HeaderText = "Tên sinh viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namsinh";
            this.Column2.HeaderText = "Năm sinh";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioitinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "monhoc";
            this.Column4.HeaderText = "Môn học";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sothich";
            this.Column5.HeaderText = "Sở thích";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ghichu";
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.Name = "Column6";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(176, 214);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(257, 214);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(338, 214);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(508, 214);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnxacnhan.TabIndex = 17;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(600, 214);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(843, 434);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridSinhVien);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBoxsothich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxmonhoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radionu);
            this.Controls.Add(this.radionam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datenamsinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensinhvien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttensinhvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datenamsinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radionam;
        private System.Windows.Forms.RadioButton radionu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxmonhoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxsothich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.DataGridView dataGridSinhVien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

