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
    public partial class GetData : Form
    {
        public GetData()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";


        // truy van 1 gia tri
        private void btnDem_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from SanPham";
            command.Connection = conn;

            object data = command.ExecuteScalar();
            int n = (int)data;
            lbSoSanPham.Text = "Có " + n + " sản phẩm";

        }
        // truy van thuong
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where Ma=" +txtMaSp.Text;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())// neu co du lieu
            {
                txtMaSP2.Text = reader.GetInt32(0) + "";
                txtTen.Text = reader.GetString(1);
                txtGia.Text = reader.GetInt32(2) + "";
            }
            reader.Close();
        }

        // truy van qua parameter
        private void btnXemChiTiet2_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where Ma=@ma";
            command.Connection = conn;

            SqlParameter parma = new SqlParameter("@ma",SqlDbType.Int);
            parma.Value = txtMaSp.Text;
            command.Parameters.Add(parma);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMaSP2.Text = reader.GetInt32(0)+"";
                txtTen.Text = reader.GetString(1);
                txtGia.Text = reader.GetInt32(2) + ""; 
            }
            reader.Close();
        }

        // truy van nhieu dong du lieu
        private void btnDS_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvDSSP.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0)+"");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                lvDSSP.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
