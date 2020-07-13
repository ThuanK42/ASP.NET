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
    public partial class Them : Form
    {
        public Them()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";
        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDanhSachToanBoSanPham();
        }

        private void HienThiDanhSachToanBoSanPham()
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvSanPham2.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0)+"");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                lvSanPham2.Items.Add(lvi);
            }

            reader.Close();
        }

        //them san pham truc tiep ko dung parameter
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "Insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)" +
                " values("+txtMa.Text+",N'"+txtTen.Text+"',"+txtGia.Text+","+txtDanhMuc.Text+")";

            command.CommandText = sql;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
            if(ret > 0)
            {
                HienThiDanhSachToanBoSanPham();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        // dung parametter
        private void btnLuuParameter_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null) conn = new SqlConnection(sqlConn);
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;

                string sql = "Insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)" +
                    " values(@ma1,@ten1,@gia1,@madm1 )";

                command.CommandText = sql;
                command.Connection = conn;

                command.Parameters.Add("@ma1", SqlDbType.Int).Value = txtMa.Text;
                command.Parameters.Add("@ten1", SqlDbType.NVarChar).Value = txtTen.Text;
                command.Parameters.Add("@gia1", SqlDbType.Int).Value = txtGia.Text;
                command.Parameters.Add("@madm1", SqlDbType.Int).Value = txtDanhMuc.Text;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiDanhSachToanBoSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
