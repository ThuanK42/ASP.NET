using QuanLySinhVienDemo.Dao;
using QuanLySinhVienDemo.Object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVienDemo
{
    public partial class QuanLySinhVien : Form
    {
        private List<Student> students;
        private string classrooms;
        public StudentDao st;

        public QuanLySinhVien(List<Student> listStudent, string listClass)
        {
            InitializeComponent();
            this.students = listStudent;
            this.classrooms = listClass;
            st = new StudentDao(students);
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            HienThiLopLenCombobox();
            HienThiDanhSachSinhVien();
        }

        private void HienThiDanhSachSinhVien()
        {
            lvSinhVien.Items.Clear();
            foreach (Student st in st.LayDanhSachSinhVien())
            {
                ListViewItem lvi = new ListViewItem(st.codeClass);
                lvi.SubItems.Add(st.codeStudent + "");
                lvi.SubItems.Add(st.nameStudent);
                lvi.SubItems.Add(st.genderStudent);
                lvi.SubItems.Add(st.address);

                lvSinhVien.Items.Add(lvi);
            }
        }

        private void HienThiLopLenCombobox()
        {
            cboMaLop2.Items.Clear();

                cboMaLop2.Items.Add(classrooms);
           
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLop qll = new QuanLyLop();
            qll.Show();
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            string diachi = txtDiaChi.Text.Trim();
            string tensv = txtTenSV.Text.Trim();
            string mssv = txtMSSV.Text.Trim();
            string malop;
            string gioitinh;
            if (radNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            if (cboMaLop2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon ma lop them sinh vien");
            }
            else
            {
                int count =st.LayDanhSachSinhVien().Count;
                malop = cboMaLop2.SelectedItem.ToString().Trim();
                if (KiemTraThongTinSinhVienCoThieuKhong(mssv, tensv, diachi) == false)
                {
                    st.ThemSinhVien(new Student(malop, mssv, tensv, gioitinh, diachi));
                    if (st.LayDanhSachSinhVien().Count > count) {
                        MessageBox.Show("Them sinh vien thanh cong");
                        lvSinhVien.Items.Clear();
                        HienThiDanhSachSinhVien();
                        cboMaLop2.Text = "";
                        txtDiaChi.Text = "";
                        txtMSSV.Text = "";
                        txtTenSV.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Them sinh vien that bai");
                        lvSinhVien.Items.Clear();
                        HienThiDanhSachSinhVien();
                        cboMaLop2.Text = "";
                        txtDiaChi.Text = "";
                        txtMSSV.Text = "";
                        txtTenSV.Text = "";
                    }
                }
                

            }
        }

        private bool KiemTraThongTinSinhVienCoThieuKhong(string mssv, string namest, string diachi)
        {
            if (mssv == "" && namest == "" && diachi == "")
            {
                MessageBox.Show("Can dien day du thong tin");
                return true;
            }

            else if (mssv == "")
            {
                MessageBox.Show("Can dien ma sinh vien");
                return true;
            }
            else if (namest == "")
            {
                MessageBox.Show("Can dien ten sinh vien");
                return true;
            }
            else if (diachi == "")
            {
                MessageBox.Show("Can dien dia chi");
                return true;
            }
            else if (mssv != "" && namest != "" && diachi != "")
            {
                return false;
            }
            return true;
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            string diachi = txtDiaChi.Text.Trim();
            string tensv = txtTenSV.Text.Trim();
            string mssv = txtMSSV.Text.Trim();
            string malop;
            string gioitinh;
            if (radNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            if (cboMaLop2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon ma lop them sinh vien");
            }
            else
            {
                malop = cboMaLop2.SelectedItem.ToString().Trim();
                if (KiemTraThongTinSinhVienCoThieuKhong(mssv, tensv, diachi) == false)
                {
                    st.CapNhatThongTinSinhVien(new Student(malop, mssv, tensv, gioitinh, diachi));
                    MessageBox.Show("Cap nhat thanh cong");
                    lvSinhVien.Items.Clear();
                    HienThiDanhSachSinhVien();
                    cboMaLop2.Text = "";
                    txtDiaChi.Text = "";
                    txtMSSV.Text = "";
                    txtTenSV.Text = "";
                }
                else {
                    MessageBox.Show("Cap nhat that bai");
                    lvSinhVien.Items.Clear();
                    HienThiDanhSachSinhVien();
                    cboMaLop2.Text = "";
                    txtDiaChi.Text = "";
                    txtMSSV.Text = "";
                    txtTenSV.Text = "";
                }
                
            }
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if(mssv != null)
            {
                st.XoaSinhVien(mssv);
                
                lvSinhVien.Items.Clear();
                HienThiDanhSachSinhVien();
                cboMaLop2.Text = "";
                txtDiaChi.Text = "";
                txtMSSV.Text = "";
                txtTenSV.Text = "";
            }
        }


    }
}