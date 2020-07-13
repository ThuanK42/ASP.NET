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
    public partial class GetList : Form
    {
        public GetList()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog= QuanLySanPhamCSharp;Integrated Security = True";
        private void Form2_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;

            lsbDanhMuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string line = reader.GetInt32(0) + "-" + reader.GetString(1);
                lsbDanhMuc.Items.Add(line);
            }

            reader.Close();
        }

        private void lsbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDanhMuc.SelectedIndex == -1) return;
            string line = lsbDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            int madm = int.Parse(arr[0]);
            if (conn == null) conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where MaDanhMuc = @madm";
            command.Connection = conn;

            SqlParameter parma = new SqlParameter("@madm", SqlDbType.Int);
            parma.Value = madm;
            command.Parameters.Add(parma);

            lvDSSP.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                ListViewItem lvi = new ListViewItem(ma + "");
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(gia + "");
                lvDSSP.Items.Add(lvi);
            }

            reader.Close();
        }
    }
}
