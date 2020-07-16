using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_QLSV_OOP.Model;

namespace WindowsFormsApp_QLSV_OOP
{
    public partial class frmSinhVien : Form
    {
        List<SinhVien> listSinhVien = new List<SinhVien>();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            showListSinhVien();
        }
        public void showListSinhVien()
        {
            ManagerSinhVien msv = new ManagerSinhVien();
            listSinhVien = msv.getListSinhvien();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Email");
            dt.Columns.Add("DiaChi");
            foreach(SinhVien s in listSinhVien)
            {
                dt.Rows.Add(s.MaSV, s.TenSV, s.Email, s.Diachi);
            }
            dataGridListSV.DataSource = dt;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddSinhVien frmAddSinhVien = new frmAddSinhVien();
            frmAddSinhVien.ShowDialog();

            if(frmAddSinhVien.SinhVien != null)
            {
                listSinhVien.Add(frmAddSinhVien.SinhVien);

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("Email");
                dt.Columns.Add("DiaChi");
                foreach (SinhVien s in listSinhVien)
                {
                    dt.Rows.Add(s.MaSV, s.TenSV, s.Email, s.Diachi);
                }

                dataGridListSV.DataSource = dt;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmAddSinhVien frmSua = new frmAddSinhVien();
            SinhVien sv = null;
            string mssv = dataGridListSV.CurrentRow.Cells[0].Value.ToString();
            foreach(SinhVien s in listSinhVien)
            {
                if (s.MaSV.Equals(mssv))
                {
                    sv = s;
                    break;
                }
            }
            frmSua.SinhVien = sv;
            frmSua.ShowDialog();

            if (frmSua.SinhVien != null)
            {
                int index = dataGridListSV.CurrentCell.RowIndex;
                

                listSinhVien.RemoveAt(index);

                listSinhVien.Insert(index, frmSua.SinhVien);

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("Email");
                dt.Columns.Add("DiaChi");
                foreach (SinhVien s in listSinhVien)
                {
                    dt.Rows.Add(s.MaSV, s.TenSV, s.Email, s.Diachi);
                }

                dataGridListSV.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa sinh viên này?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int index = dataGridListSV.CurrentCell.RowIndex;
                listSinhVien.RemoveAt(index);

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("Email");
                dt.Columns.Add("DiaChi");
                foreach (SinhVien s in listSinhVien)
                {
                    dt.Rows.Add(s.MaSV, s.TenSV, s.Email, s.Diachi);
                }

                dataGridListSV.DataSource = dt;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtHoTen.Text;
            List<SinhVien> listSVTimKiem = new List<SinhVien>();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                foreach (SinhVien s in listSinhVien)
                {
                    if (s.TenSV.ToLower().Contains(tukhoa.ToLower()))
                    {
                        listSVTimKiem.Add(s);
                        break;
                    }
                }
            }
            else
            {
                listSVTimKiem = listSinhVien;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Email");
            dt.Columns.Add("DiaChi");
            foreach (SinhVien s in listSVTimKiem)
            {
                dt.Rows.Add(s.MaSV, s.TenSV, s.Email, s.Diachi);
            }

            dataGridListSV.DataSource = dt;
        }
    }
}
