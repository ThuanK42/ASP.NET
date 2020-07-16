using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        List<SinhVien> listSV;
        string themOrsua;
        string tensinhvien, namsinh, gioitinh, monhoc, sothich, ghichu;
        public Form1()
        {
            InitializeComponent();
            listSV = new List<SinhVien>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            filldataMonhoc();
        }
        public void filldataMonhoc()
        {
            string[] obj = { "Toán", "Văn", "Ngoại ngữ", "Hóa", "Lý" };
            comboBoxmonhoc.DataSource = obj;
            lockObjetc();
        }

        private void datenamsinh_ValueChanged(object sender, EventArgs e)
        {
            namsinh = datenamsinh.Value.ToString();
        }

        private void radionam_Click(object sender, EventArgs e)
        {
            if (radionam.Checked)
            {
                gioitinh = "Nam";
            }
        }

        private void radionu_Click(object sender, EventArgs e)
        {
            if (radionu.Checked)
            {
                gioitinh = "Nữ";

            }
        }

        private void comboBoxmonhoc_SelectedValueChanged(object sender, EventArgs e)
        {
            monhoc = comboBoxmonhoc.SelectedItem.ToString();
        }

        private void checkedListBoxsothich_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public bool checkdata()
        {
            if (string.IsNullOrEmpty(txttensinhvien.Text))
            {
                MessageBox.Show("Bạn cần nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensinhvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtghichu.Text))
            {
                MessageBox.Show("Bạn cần nhập ghi chu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensinhvien.Focus();
                return false;
            }
            return true;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (themOrsua == "them")
            {
                if (checkdata())
                {
                    tensinhvien = txttensinhvien.Text;
                    ghichu = txtghichu.Text;
                    //duyệt combobox sơ rthichs
                    System.Windows.Forms.CheckedListBox.CheckedItemCollection items = checkedListBoxsothich.CheckedItems;
                    foreach (var sthich in items)
                    {
                        sothich += sthich + ",";
                    }
                    SinhVien sinhVien = new SinhVien(tensinhvien, namsinh, gioitinh, monhoc, sothich, ghichu);
                    listSV.Add(sinhVien);
                    dataGridSinhVien.DataSource = null;
                    dataGridSinhVien.DataSource = listSV;
                    checkedListBoxsothich.CheckOnClick = false;
                    dataGridSinhVien.Refresh();


                }
                
            }
            else
            {
                if (themOrsua == "sua")
                {
                    if (checkdata())
                    {
                        if (index >= 0)
                        {
                            listSV[index].tensinhvien = txttensinhvien.Text;
                            listSV[index].ghichu = txtghichu.Text;

                        }
                    }
                }
            }
            lockObjetc();



        }
        int index;

        private void dataGridSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txttensinhvien.Text = listSV[index].tensinhvien.ToString();
                txtghichu.Text = listSV[index].ghichu.ToString();
            }
        }

        private void dataGridSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dataGridSinhVien.Rows[e.RowIndex];
            if (row.Index >= 0)
            {
                tensinhvien = row.Cells[0].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa SV?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listSV.RemoveAt(index);
                dataGridSinhVien.DataSource = null;
                dataGridSinhVien.DataSource = listSV;
            }
        }

        public void lockObjetc()
        {
            txttensinhvien.ReadOnly = true;
            txtghichu.ReadOnly = true;

            datenamsinh.Enabled = false;
            radionam.Enabled = false;
            radionu.Enabled = false;
            comboBoxmonhoc.Enabled = false;
            checkedListBoxsothich.Enabled = false;

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;

            btnxacnhan.Enabled = false;
            btnhuy.Enabled = false;

            btnthem.Focus();
        }
        public void unlockObjetc()
        {
            txttensinhvien.ReadOnly = false;
            txtghichu.ReadOnly = false;

            datenamsinh.Enabled = true;
            radionam.Enabled = true;
            radionu.Enabled = true;
            comboBoxmonhoc.Enabled = true;
            checkedListBoxsothich.Enabled = true;

            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;

            btnxacnhan.Enabled = true;
            btnhuy.Enabled = true;
            txttensinhvien.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            unlockObjetc();
            themOrsua = "them";
            txttensinhvien.Text = "";
            txtghichu.Text = "";
            sothich = "";
            radionam.Checked = false;
            radionu.Checked = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            unlockObjetc();
            themOrsua = "sua";
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            lockObjetc();
            txttensinhvien.Text = "";
            txtghichu.Text = "";
        }
    }
}
