using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_QLSV_OOP.Model;

namespace WindowsFormsApp_QLSV_OOP
{
    public partial class frmAddSinhVien : Form
    {
        private SinhVien sinhVien = null;
        public frmAddSinhVien()
        {
            InitializeComponent();
        }

        internal SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            sinhVien = new SinhVien();
            sinhVien.MaSV = txtMaSV.Text;
            sinhVien.TenSV = txtTenSV.Text;
            sinhVien.Email = txtEmail.Text;
            sinhVien.Diachi = txtDiaChi.Text;
            this.Close();
        }

        private void frmAddSinhVien_Load(object sender, EventArgs e)
        {
            if(sinhVien != null)
            {
                this.Text = "Sửa thông tin";
                txtMaSV.Text = sinhVien.MaSV;
                txtMaSV.Enabled = false;
                txtTenSV.Text = sinhVien.TenSV;
                txtEmail.Text = sinhVien.Email;
                txtDiaChi.Text = sinhVien.Diachi;
            }
            else
            {
                this.Text = "Thêm thông tin";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
