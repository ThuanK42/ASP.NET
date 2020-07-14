using QuanLySinhVienDemo.Dao;
using System;
using System.Windows.Forms;

namespace QuanLySinhVienDemo
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private UserDao ud = new UserDao();

        private void btnDK_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dk = new DangKy();
            dk.Show();
        }

        private void btnDN_Click(object sender, EventArgs e)

        {
            string userName = txtTenDN.Text.Trim();
            string pass = txtMK.Text.Trim();

            if (kiemTraThongTin(userName, pass) == true)
            {
                if (ud.DangNhap(userName, pass) == true)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                    QuanLyLop qll = new QuanLyLop();
                    qll.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
        }

        private bool kiemTraThongTin(string userName, string pass)
        {
            if (userName == "" && pass == "")
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
            else if (userName != null && pass != null)
            {
                return true;
            }

            return false;
        }
    }
}