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
    public partial class frmEX6 : Form
    {
        public frmEX6()
        {
            InitializeComponent();
        }

        private void btnDigitar_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(txbNum.Text);
            double d = 1;

            while (d <= num)
            {
                rtbBrasil.Text = rtbBrasil.Text + "Brasil\n";
                d++;
            }

        }
    }
}
