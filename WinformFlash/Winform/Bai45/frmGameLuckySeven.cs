using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai45
{
    public partial class frmGameLuckySeven : Form
    {
        public frmGameLuckySeven()
        {
            InitializeComponent();
        }

        int tienMay = 100;
        int tienNguoi = 100;
        int count = 0;
        Random rd = new Random();

        private void frmGameLuckySeven_Load(object sender, EventArgs e)
        {

        }


        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if(tienNguoi < 30)
            {
                MessageBox.Show("Bốc cái bát 90 mà cầm về tới tận 15 triệu !");
                return;
            }
            tienNguoi = tienNguoi - 30;
            tienMay = tienMay + 30;
            count = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int so1 = rd.Next(9);
            int so2 = rd.Next(10);
            int so3 = rd.Next(11);

            lbl1.Text = so1 + "";
            lbl2.Text = so2 + "";
            lbl3.Text = so3 + "";

            if (count >100)
            {
                if (so1 == 7) 
                { 
                    tienNguoi = tienNguoi + 100 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if(so2  == 7)
                {
                    tienNguoi = tienNguoi + 30 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if(so3 == 7)
                {
                    tienNguoi = tienNguoi + 10;
                }
                lblTienMay.Text = tienMay + "";
                lblTienNguoiChoi.Text = tienNguoi + "";
                timer1.Stop();
            }
            count++;
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            lblTienMay.Text = 100 + "";
            lblTienNguoiChoi.Text = 100 + "";
            tienMay = 100;
            tienNguoi = 100;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mãi bên nhau bạn nhớ !");
            Close();
        }
    }
}
