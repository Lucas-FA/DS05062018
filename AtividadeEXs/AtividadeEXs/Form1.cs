using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX1 ex1 = new frmEX1();
            ex1.MdiParent = this;
            ex1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX2 ex2 = new frmEX2();
            ex2.MdiParent = this;
            ex2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX3 ex3 = new frmEX3();
            ex3.MdiParent = this;
            ex3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX4 ex4 = new frmEX4();
            ex4.MdiParent = this;
            ex4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX5 ex5 = new frmEX5();
            ex5.MdiParent = this;
            ex5.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX6 ex6 = new frmEX6();
            ex6.MdiParent = this;
            ex6.Show();
        }

        private void exercício7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEX7 ex7 = new frmEX7();
            ex7.MdiParent = this;
            ex7.Show();
        }
    }
}
