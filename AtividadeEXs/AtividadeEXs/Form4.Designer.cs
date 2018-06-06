namespace WindowsFormsApplication1
{
    partial class frmEX3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLado1 = new System.Windows.Forms.Label();
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(12, 28);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 13);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            // 
            // txbLado1
            // 
            this.txbLado1.Location = new System.Drawing.Point(172, 25);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(100, 20);
            this.txbLado1.TabIndex = 1;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(12, 64);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(40, 13);
            this.lblLado2.TabIndex = 2;
            this.lblLado2.Text = "Lado 2";
            // 
            // txbLado2
            // 
            this.txbLado2.Location = new System.Drawing.Point(172, 61);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(100, 20);
            this.txbLado2.TabIndex = 3;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(12, 103);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(40, 13);
            this.lblLado3.TabIndex = 4;
            this.lblLado3.Text = "Lado 3";
            // 
            // txbLado3
            // 
            this.txbLado3.Location = new System.Drawing.Point(172, 100);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(100, 20);
            this.txbLado3.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(99, 159);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 226);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(16, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "---";
            // 
            // frmEX3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbLado3);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.txbLado2);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.txbLado1);
            this.Controls.Add(this.lblLado1);
            this.Name = "frmEX3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.TextBox txbLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txbLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox txbLado3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblTipo;
    }
}