using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public bool checkControl()
        {
            if (string.IsNullOrEmpty(txttendangnhap.Text))
            {
                MessageBox.Show("Bạn hãy nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendangnhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Bạn hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendangnhap.Focus();
                return false;
            }
            return true;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                if (txttendangnhap.Text.Equals("admin") && txtmatkhau.Text.Equals("admin"))
                {
                    this.Hide();
                }
                else
                {
                    lbthongbao.Visible = true;
                    lbthongbao.Text = "Đăng nhập thất bại";
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
