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
    public partial class ProcedureSQL : Form
    {
        public ProcedureSQL()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";

        private void ProcedureSQL_Load(object sender, EventArgs e)
        {
            HienThiToanBoSanPham();
        }

        private void HienThiToanBoSanPham()
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoSanPham";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvSanPham.Items.Clear();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);

                ListViewItem lvi = new ListViewItem(ma + "");
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(gia+"");
                lvSanPham.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            HienThiChiTietSanPham(ma);
        }

        private void HienThiChiTietSanPham(int ma)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChiTietSanPham";
            command.Connection = conn;

            SqlParameter parma = new SqlParameter("@ma",SqlDbType.Int);
            parma.Value = ma;
            command.Parameters.Add(parma);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMa.Text = reader.GetInt32(0)+"";
                txtTen.Text = reader.GetString(1);
                txtGia.Text = reader.GetInt32(2) + "";
                txtDM.Text = reader.GetInt32(3) + "";
            }
            reader.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSanPham";
            command.Connection = conn;

            command.Parameters.Add("@ma",SqlDbType.Int).Value= txtMa.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;
            command.Parameters.Add("@madm", SqlDbType.Int).Value = txtDM.Text;

            int ret = command.ExecuteNonQuery();
            if(ret > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Da them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatGia";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaSanPham";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
    }
}
