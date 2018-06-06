namespace WindowsFormsApplication1
{
    partial class frmEX4
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
            this.lblNumMes = new System.Windows.Forms.Label();
            this.txbMes = new System.Windows.Forms.TextBox();
            this.btnMes = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumMes
            // 
            this.lblNumMes.AutoSize = true;
            this.lblNumMes.Location = new System.Drawing.Point(12, 38);
            this.lblNumMes.Name = "lblNumMes";
            this.lblNumMes.Size = new System.Drawing.Size(135, 13);
            this.lblNumMes.TabIndex = 0;
            this.lblNumMes.Text = "Digite o número de um mês";
            // 
            // txbMes
            // 
            this.txbMes.Location = new System.Drawing.Point(172, 35);
            this.txbMes.Name = "txbMes";
            this.txbMes.Size = new System.Drawing.Size(100, 20);
            this.txbMes.TabIndex = 1;
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(106, 131);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 23);
            this.btnMes.TabIndex = 2;
            this.btnMes.Text = "Verificar";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 200);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(16, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "---";
            // 
            // frmEX4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.lblNumMes);
            this.Name = "frmEX4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMes;
        private System.Windows.Forms.TextBox txbMes;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Label lblMes;
    }
}