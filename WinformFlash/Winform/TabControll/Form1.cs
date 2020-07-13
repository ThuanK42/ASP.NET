using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)// tab 1 dang duoc chon
            {
                btnColor.BackColor = Color.Red;
            }else if (tabControl1.SelectedIndex ==1)// tab 2 duoc chon
            {
                richTextBox1.BackColor = Color.Yellow;
            }
        }
    }
}
