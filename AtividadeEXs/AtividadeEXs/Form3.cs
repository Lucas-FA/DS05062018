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
    public partial class frmEX2 : Form
    {
        public frmEX2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbNum1.Text);
            double resto2 = num1 % 2;
            double resto5 = num1 % 5;
            double resto10 = num1 % 10;

            if (resto2 == 0 && resto5 == 0 && resto10 == 0)
            {
                lblDiv.Text = "O número é divisível por 2, por 5 e por 10";
            }

            else if (resto2 == 0 && resto5 == 0)
            {
                lblDiv.Text = "O número é divisível por 2 e por 5";
            }

            else if (resto2 == 0 && resto10 == 0)
            {
                lblDiv.Text = "O número é divisível por 2 e por 10";
            }

            else if (resto5 == 0 && resto10 == 0)
            {
                lblDiv.Text = "O número é divisível por 5 e por 10";
            }

            else if (resto2 == 0)
            {
                lblDiv.Text = "O número é divisível por 2";
            }

            else if (resto5 == 0)
            {
                lblDiv.Text = "O número é divisível por 5";
            }

            else if (resto10 == 0)
            {
                lblDiv.Text = "O número é divisível por 10";
            }

            else
                lblDiv.Text = "O número NÃO é divisível por 2, 5 ou 10";
        }
    }
}
