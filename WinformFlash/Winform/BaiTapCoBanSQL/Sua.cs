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
    public partial class Sua : Form
    {
        public Sua()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";
        private void Sua_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
        }

        private void HienThiDanhMuc()
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            cboDM.Items.Clear();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                cboDM.Items.Add(ma+" - "+ten);
            }

            reader.Close();
        }

        int madm = -1;
        private void cboDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDM.SelectedIndex == -1) return;
            string line = cboDM.SelectedItem + "";
            string[] arr = line.Split('-');
             madm = int.Parse(arr[0]);
            HienThiSanPhamTheoDanhMuc(madm);
        }

        private void HienThiSanPhamTheoDanhMuc(int madm)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where MaDanhMuc = "+madm;
            command.Connection = conn;

            lvSanPham.Items.Clear();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read()){
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                lvSanPham.Items.Add(lvi);

            }
            reader.Close();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            txtMa.Text = lvi.SubItems[0].Text;
            txtTen.Text = lvi.SubItems[1].Text;
            txtGia.Text = lvi.SubItems[2].Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "update SanPham set Ten=N'"+ txtTen.Text + "',DonGia=" + txtGia.Text + "where Ma=" + txtMa.Text;

            command.CommandText = sql;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPhamTheoDanhMuc(madm);
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat thất bại");
            }
        }

        private void btnCapNhatParameter_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "update SanPham set Ten=@ten1,DonGia=@gia1 where Ma=@ma1 ";

            command.CommandText = sql;
            command.Connection = conn;

            command.Parameters.Add("@ma1", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@ten1", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@gia1", SqlDbType.Int).Value = txtGia.Text;
            

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPhamTheoDanhMuc(madm);
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat thất bại");
            }
        }
    }
}
