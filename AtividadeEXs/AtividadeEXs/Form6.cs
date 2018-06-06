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
    public partial class frmEX5 : Form
    {
        public frmEX5()
        {
            InitializeComponent();
        }

        private void btnDigitar_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(txbNum.Text);

            if (num <= 50)
            {
                double d = 1;

                while (d <= num)
                {
                    rtbDigitar.Text = rtbDigitar.Text + d.ToString() + "\n";
                    d++;
                }
            }

            else
                rtbDigitar.Text = "O número digitado é maior que 50";
        }
    }
}
