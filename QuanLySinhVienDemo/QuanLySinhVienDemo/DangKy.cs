using QuanLySinhVienDemo.Dao;
using System;
using System.Windows.Forms;

namespace QuanLySinhVienDemo
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private UserDao ud = new UserDao();

        private bool kiemTraThongTin(string userName, string pass, string repass)
        {
            if (userName == "" && pass == "" &&
                repass == "")
            {
                MessageBox.Show("Vui long dien day du cac thong tin");
                return false;
            }
            else if (userName == "")
            {
                MessageBox.Show("Ban chua dien ten dang nhap");
                return false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Ban chua dien mat khau");
                return false;
            }
            else if (repass == "")
            {
                MessageBox.Show("Ban chua dien nhap lai mat khau");
                return false;
            }
            else if (pass.Equals(repass) == false)
            {
                MessageBox.Show("2 mat khau khong trung nhau");
                return false;
            }
            else if (userName != null && pass != null &&
                repass != null && pass.Equals(repass) == true)
            {
                return true;
            }

            return false;
        }

        private void btnDK_Click_1(object sender, EventArgs e)
        {
            string userName = txtTenDN.Text.Trim();
            string pass = txtMK.Text.Trim();
            string repass = txtNhapLaiMK.Text.Trim();

            if (kiemTraThongTin(userName, pass, repass) == true)
            {
                if (ud.DangKy(userName, pass) == true)
                {
                    MessageBox.Show("Dang ky thanh cong");
                    this.Hide();
                    DangNhap form1 = new DangNhap();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Dang ky that bai");
                }
            }
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap form1 = new DangNhap();
            form1.Show();
        }
    }
}