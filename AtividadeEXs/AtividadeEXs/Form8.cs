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
    public partial class frmEX7 : Form
    {
        public frmEX7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double alturaArlindo = 1.50;
            double alturaManoel = 1.10;
            double d = 1;

            while (alturaManoel <= alturaArlindo)
            {
                alturaArlindo += 0.02;
                alturaManoel += 0.03;
                d++;
            }

            lblAnos.Text = "Serão necessários " + d + " anos para Manoel ser mais alto que Arlindo.";
        }
    }
}
