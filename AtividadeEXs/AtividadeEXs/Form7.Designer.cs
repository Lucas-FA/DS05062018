namespace WindowsFormsApplication1
{
    partial class frmEX6
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnDigitar = new System.Windows.Forms.Button();
            this.rtbBrasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(25, 31);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(89, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite um número";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(156, 28);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 20);
            this.txbNum.TabIndex = 1;
            // 
            // btnDigitar
            // 
            this.btnDigitar.Location = new System.Drawing.Point(96, 77);
            this.btnDigitar.Name = "btnDigitar";
            this.btnDigitar.Size = new System.Drawing.Size(75, 23);
            this.btnDigitar.TabIndex = 2;
            this.btnDigitar.Text = "Digitar Brasil";
            this.btnDigitar.UseVisualStyleBackColor = true;
            this.btnDigitar.Click += new System.EventHandler(this.btnDigitar_Click);
            // 
            // rtbBrasil
            // 
            this.rtbBrasil.Location = new System.Drawing.Point(12, 120);
            this.rtbBrasil.Name = "rtbBrasil";
            this.rtbBrasil.Size = new System.Drawing.Size(260, 185);
            this.rtbBrasil.TabIndex = 3;
            this.rtbBrasil.Text = "";
            // 
            // frmEX6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.rtbBrasil);
            this.Controls.Add(this.btnDigitar);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Name = "frmEX6";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnDigitar;
        private System.Windows.Forms.RichTextBox rtbBrasil;
    }
}