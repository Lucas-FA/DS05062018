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
    public partial class frmEX1 : Form
    {
        public frmEX1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double res2;
            double num1 = System.Convert.ToDouble(txbNum1.Text);
            double num2 = System.Convert.ToDouble(txbNum2.Text);
            double res1 = num1 + num2;

            if (res1 > 20)
            {
                res2 = res1 + 8;
                lblRes.Text = "O valor da soma é maior que 20\nResultado: " + res2;
            }

            else
                res2 = res1 - 5;
                lblRes.Text = "O valor da soma é menor ou igual a 20\nResultado: " + res2;
        }
    }
}
