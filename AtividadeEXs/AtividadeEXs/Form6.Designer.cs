namespace WindowsFormsApplication1
{
    partial class frmEX5
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
            this.rtbDigitar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(24, 31);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(122, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite um número até 50";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(155, 28);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 20);
            this.txbNum.TabIndex = 1;
            // 
            // btnDigitar
            // 
            this.btnDigitar.Location = new System.Drawing.Point(70, 86);
            this.btnDigitar.Name = "btnDigitar";
            this.btnDigitar.Size = new System.Drawing.Size(133, 23);
            this.btnDigitar.TabIndex = 2;
            this.btnDigitar.Text = "Digitar números";
            this.btnDigitar.UseVisualStyleBackColor = true;
            this.btnDigitar.Click += new System.EventHandler(this.btnDigitar_Click);
            // 
            // rtbDigitar
            // 
            this.rtbDigitar.Location = new System.Drawing.Point(27, 129);
            this.rtbDigitar.Name = "rtbDigitar";
            this.rtbDigitar.ReadOnly = true;
            this.rtbDigitar.Size = new System.Drawing.Size(228, 230);
            this.rtbDigitar.TabIndex = 4;
            this.rtbDigitar.Text = "";
            // 
            // frmEX5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 390);
            this.Controls.Add(this.rtbDigitar);
            this.Controls.Add(this.btnDigitar);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Name = "frmEX5";
            this.Text = "Exercício 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnDigitar;
        private System.Windows.Forms.RichTextBox rtbDigitar;
    }
}