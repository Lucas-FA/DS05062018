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
    public partial class frmEX4 : Form
    {
        public frmEX4()
        {
            InitializeComponent();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            double mes = System.Convert.ToDouble(txbMes.Text);

            if (mes == 1)
            {
                lblMes.Text = "Janeiro";
            }

            else if (mes == 2)
            {
                lblMes.Text = "Fevereiro";
            }

            else if (mes == 3)
            {
                lblMes.Text = "Março";
            }

            else if (mes == 4)
            {
                lblMes.Text = "Abril";
            }

            else if (mes == 5)
            {
                lblMes.Text = "Maio";
            }

            else if (mes == 6)
            {
                lblMes.Text = "Junho";
            }

            else if (mes == 7)
            {
                lblMes.Text = "Julho";
            }

            else if (mes == 8)
            {
                lblMes.Text = "Agosto";
            }

            else if (mes == 9)
            {
                lblMes.Text = "Setembro";
            }

            else if (mes == 10)
            {
                lblMes.Text = "Outubro";
            }

            else if (mes == 11)
            {
                lblMes.Text = "Novembro";
            }

            else if (mes == 12)
            {
                lblMes.Text = "Dezembro";
            }
            
            else
                lblMes.Text = "O número não corresponde a um mês";
        }
    }
}
