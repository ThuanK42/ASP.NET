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

namespace KetNoiSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strConn = @"Data Source = DESKTOP-JAOQ4A2\SQLEXPRESS;Initial Catalog=QuanLyDanhBa;Integrated Security = True";

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bye bye");
            }
        }
    }
}
