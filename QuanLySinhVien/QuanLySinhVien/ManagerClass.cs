using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class ManagerClass : Form
    {
        public ManagerClass()
        {
            InitializeComponent();
        }

        private void ManagerClass_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNameClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void addClass()
        {
            string codeClass = txtMaLop.Text.Trim();
            string nameClass = txtNameClass.Text.Trim();

            if(string.IsNullOrEmpty(codeClass) == false)
            {
                MessageBox.Show("Bạn điền thiếu mã lớp");
            }else if(string.IsNullOrEmpty(nameClass) == false)
            {
                MessageBox.Show("Bạn điền thiếu tên lớp");
            }
            else
            {
                MessageBox.Show("Bạn điền thiếu thông tin");
            }




        }
    }
}
