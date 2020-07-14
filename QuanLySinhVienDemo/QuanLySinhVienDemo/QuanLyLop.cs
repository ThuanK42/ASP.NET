using QuanLySinhVienDemo.Dao;
using QuanLySinhVienDemo.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienDemo
{
    public partial class QuanLyLop : Form
    {

        public QuanLyLop()
        {
            InitializeComponent();
        }
        ClassDao cld = new ClassDao();

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            HienThiLopLenCombobox();
            HienThiDanhSachLop();

        }

        private bool KiemTraThongTinLopCoThieuKhong(string malop, string tenlop)
        {
            if (malop.Equals(null) == true && tenlop.Equals(null) == true)
            {
                MessageBox.Show("Can dien day du thong tin");
                return true;
            }
            else if (malop.Equals(null) == true)
            {
                MessageBox.Show("Can dien ma lop");
                return true;
            }
            else if (tenlop.Equals(null) == true)
            {
                MessageBox.Show("Can dien ten lop");
                return true;
            }
            else if (malop.Equals(null) == false && tenlop.Equals(null) == false)
            {
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString(); //Hiển thị thời gian hiện tại
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedIndex == -1) return;

            string cl = cboMaLop.Text;

            HienThiLop(cl);
        }

        private void HienThiLopLenCombobox()
        {
            cboMaLop.Items.Clear();
            foreach (Classroom cl in cld.LayDanhSachCacLop())
            {              
                cboMaLop.Items.Add(cl.codeClass);
            }
        }

        private void HienThiDanhSachLop() {
            foreach (Classroom cl in cld.LayDanhSachCacLop())
            {
                ListViewItem lvi = new ListViewItem(cl.codeClass);
                lvi.SubItems.Add(cl.nameClass);

                lvLop.Items.Add(lvi);
            }
        }

        private void HienThiLop(string codeClass)
        {
            lvLop.Items.Clear();
            foreach (Classroom cl in cld.LayDanhSachCacLop())
            {
                if (cl.codeClass.Equals(codeClass) == true)
                {
                    ListViewItem lvi = new ListViewItem(cl.codeClass);
                    lvi.SubItems.Add(cl.nameClass);

                    lvLop.Items.Add(lvi);
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string malop = cboMaLop.Text.Trim();
            string tenlop = txtTenLop.Text.Trim();

            if(KiemTraThongTinLopCoThieuKhong(malop,tenlop) == false)
            {
                cld.ThemLop(new Classroom(malop,tenlop, new List<Student>()));
            }
            lvLop.Items.Clear();
            HienThiDanhSachLop();
            HienThiLopLenCombobox();
        }



        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string malop = cboMaLop.Text.Trim();
            string tenlop = txtTenLop.Text.Trim();

            if (KiemTraThongTinLopCoThieuKhong(malop, tenlop) == false)
            {
                cld.CapNhatTenLop(malop, tenlop);
            }
            lvLop.Items.Clear();
            HienThiDanhSachLop();
           
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if(cboMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon ma lop trong danh sach hien tai");
            }
            else
            {
                if (cld.KiemTraLopTonTaiKhong(cboMaLop.SelectedItem.ToString()) == false)
                {
                    MessageBox.Show("Lop khong ton tai");
                }
                else
                {
                    cld.XoaLop(cboMaLop.SelectedItem.ToString());
                    lvLop.Items.Clear();
                    HienThiDanhSachLop();
                    HienThiLopLenCombobox();
                    cboMaLop.Text = "";
                }
            }
            
        }
    }
}
