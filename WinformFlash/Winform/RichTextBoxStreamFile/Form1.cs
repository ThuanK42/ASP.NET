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

namespace RichTextBoxStreamFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plan text .txt|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbNoiDung.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Đã lưu nội dung trên richtextbox xuống tập tin thành công");

            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "Plan text .txt|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFileDialog1.OpenFile();
                StreamReader sr = new StreamReader(stream);
                rtbNoiDung.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
