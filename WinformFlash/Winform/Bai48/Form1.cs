using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string ten=lvi.SubItems[1].Text;
                int gia = int.Parse(lvi.SubItems[2].Text);
                /* MessageBox.Show(ma + " "+ ten+" "+gia);*/

                txtMaSanPham.Text = ma;
                txtTenSanPham.Text = ten;
                txtDonGia.Text = gia+"";

            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column != -1)
            {
                ColumnHeader col = lvSanPham.Columns[e.Column];
                MessageBox.Show("Bạn click cột: "+col.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tao 1 list view (tao 1 dong):
            ListViewItem lvi = new ListViewItem(txtMaSanPham.Text);
            //them cot con lai
            lvi.SubItems.Add(txtTenSanPham.Text);
            lvi.SubItems.Add(txtDonGia.Text);
            //dua lvi len giao dien
            lvSanPham.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (lvSanPham.SelectedItems.Count > 0)
            {
                // Xoa theo doi tuong
                //lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);// phan tu dau tien ma ta chon
                // xoa theo vi tri
                lvSanPham.Items.RemoveAt(lvSanPham.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chưa chọn mà xóa muốn phá à ! Có tin t chọi nguyên cái code của t vào mặt ko");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {

                ListViewItem lvi = lvSanPham.SelectedItems[0];
                lvi.SubItems[0].Text = txtMaSanPham.Text;
                lvi.SubItems[1].Text = txtTenSanPham.Text;
                lvi.SubItems[2].Text = txtDonGia.Text;
            }
        }
    }
}
