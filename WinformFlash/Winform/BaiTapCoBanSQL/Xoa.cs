using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCoBanSQL
{
    public partial class Xoa : Form
    {
        public Xoa()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";

        private void HienThiSanPham()
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lsbSanPham.Items.Clear();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                lsbSanPham.Items.Add(ma + " - " + ten);
            }

            reader.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsbSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn mà xóa m bị ngu à");
            }

            string line = lsbSanPham.SelectedItem + "";
            string[] arr = line.Split('-');
            int ma = int.Parse(arr[0]);

            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanPham where Ma = "+ma;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
            if(ret > 0)
            {
                HienThiSanPham();
                MessageBox.Show("Da xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (lsbSanPham.SelectedIndex == -1) return;
            

            string line = lsbSanPham.SelectedItem.ToString();
            string[] arr = line.Split('-');
            int ma = int.Parse(arr[0]);

            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanPham where Ma = @ma";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma ;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPham();
                MessageBox.Show("Da xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void Xoa_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }
    }
}
