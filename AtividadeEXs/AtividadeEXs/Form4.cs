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
    public partial class frmEX3 : Form
    {
        public frmEX3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbLado1.Text);
            double num2 = System.Convert.ToDouble(txbLado2.Text);
            double num3 = System.Convert.ToDouble(txbLado3.Text);

            if (num1 == num2 && num1 == num3)
            {
                lblTipo.Text = "Triângulo Equilátero";
            }

            else if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                lblTipo.Text = "Triângulo Isósceles";
            }

            else
                lblTipo.Text = "Triângulo Escaleno";
        }
    }
}
