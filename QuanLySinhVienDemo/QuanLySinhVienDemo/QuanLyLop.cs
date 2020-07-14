using QuanLySinhVienDemo.Dao;
using QuanLySinhVienDemo.Object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVienDemo
{
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private ClassDao cld = new ClassDao();

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            HienThiLopLenCombobox();
            HienThiDanhSachLop();
        }

        private static List<Student> lstStudent = new List<Student>();

        private bool KiemTraThongTinLopCoThieuKhong(string malop, string tenlop)
        {
            if (malop == "" && tenlop == "")
            {
                MessageBox.Show("Can dien day du thong tin");
                return true;
            }
            else if (malop == "")
            {
                MessageBox.Show("Can dien ma lop");
                return true;
            }
            else if (tenlop == "")
            {
                MessageBox.Show("Can dien ten lop");
                return true;
            }
            else if (malop != "" && tenlop != "")
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

        private void HienThiDanhSachLop()
        {
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
            int count = cld.LayDanhSachCacLop().Count;
            if (KiemTraThongTinLopCoThieuKhong(malop, tenlop) == false)
            {
                cld.ThemLop(new Classroom(malop, tenlop, new List<Student>()));
                if (cld.LayDanhSachCacLop().Count > count)
                {
                    MessageBox.Show("Them thanh cong");
                    lvLop.Items.Clear();
                    HienThiDanhSachLop();
                    HienThiLopLenCombobox();
                    cboMaLop.Text = "";
                    txtTenLop.Text = "";
                }
                else
                {
                    MessageBox.Show("Them that bai");
                    lvLop.Items.Clear();
                    HienThiDanhSachLop();
                    HienThiLopLenCombobox();
                    cboMaLop.Text = "";
                    txtTenLop.Text = "";
                }
            }
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
            cboMaLop.Text = "";
            txtTenLop.Text = "";
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedIndex == -1)
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
                    int count = cld.LayDanhSachCacLop().Count;
                    cld.XoaLop(cboMaLop.SelectedItem.ToString());

                    if (cld.LayDanhSachCacLop().Count < count)
                    {
                        MessageBox.Show("Xoa lop thanh cong");
                        lvLop.Items.Clear();
                        HienThiDanhSachLop();
                        HienThiLopLenCombobox();
                        cboMaLop.Text = "";
                        txtTenLop.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xoa lop that bai");
                        lvLop.Items.Clear();
                        HienThiDanhSachLop();
                        HienThiLopLenCombobox();
                        cboMaLop.Text = "";
                        txtTenLop.Text = "";
                    }
                }
            }
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon ma lop de xem danh sach sinh vien lop do");
            }
            else
            {
                if (cld.KiemTraLopTonTaiKhong(cboMaLop.SelectedItem.ToString()) == false)
                {
                    MessageBox.Show("Lop khong ton tai");
                }
                else
                {
                    this.Hide();
                    QuanLySinhVien qlsv = new QuanLySinhVien(cld.LayDanhSachSinhVienTheoMaLop(cboMaLop.SelectedItem.ToString()), cboMaLop.SelectedItem.ToString());
                    qlsv.Show();
                }
            }
        }
    }
}