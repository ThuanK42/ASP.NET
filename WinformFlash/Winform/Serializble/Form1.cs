using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> dsSV = new List<SinhVien>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.NamSinh = dtpNamSinh.Value;
            dsSV.Add(sv);
            HienThiSinhVien();
        }

        void HienThiSinhVien()
        {
            lsbDSSV.Items.Clear();
            foreach (SinhVien sv in dsSV)
            {
                lsbDSSV.Items.Add(sv.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            bool kt = FileFactory.LuuFile(dsSV, path);
            if(kt == true)
            {
                MessageBox.Show("Lưu thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            dsSV = FileFactory.DocFile(path);
            HienThiSinhVien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            if(File.Exists(path))
            {
                dsSV = FileFactory.DocFile(path);
                HienThiSinhVien();
            }    
        }
    }
}
