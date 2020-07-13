using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            dsNV.Add(new NhanVien { Ma = 1, Ten = "Le Van Thuan", Phone = "0983172229" });
            dsNV.Add(new NhanVien { Ma = 2, Ten = "Nguyen Van Quang", Phone = "0983173339" });
            dsNV.Add(new NhanVien { Ma = 3, Ten = "Tran Viet Son", Phone = "0983174449" });
            dsNV.Add(new NhanVien { Ma = 4, Ten = "Nguyen Hieu", Phone = "0983175559" });
            dsNV.Add(new NhanVien { Ma = 5, Ten = "To Thanh Sang", Phone = "0983176669" });

            gvNhanVien.DataSource = dsNV;
        }

        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex == -1) return;
            DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);
            */
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = gvNhanVien.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);
        }
    }
}
