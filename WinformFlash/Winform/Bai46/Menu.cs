using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai46
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFileNewProject_Click(object sender, EventArgs e)
        {
            frmAddNewProject frm = new frmAddNewProject();
            frm.Show();
        }

        private void sieuNhanDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for(int i =0; i <10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(100)+"";
                flowLayoutPanel1.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
            }
        }
    }
}
