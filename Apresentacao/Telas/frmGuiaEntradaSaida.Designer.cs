namespace Apresentacao.Telas
{
    partial class frmGuiaEntradaSaida
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
            this.wbGuia = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbGuia
            // 
            this.wbGuia.Location = new System.Drawing.Point(24, 17);
            this.wbGuia.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGuia.Name = "wbGuia";
            this.wbGuia.Size = new System.Drawing.Size(1137, 387);
            this.wbGuia.TabIndex = 0;
            // 
            // frmGuiaEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 431);
            this.Controls.Add(this.wbGuia);
            this.Name = "frmGuiaEntradaSaida";
            this.Text = "frmGuiaEntradaSaida";
            this.Load += new System.EventHandler(this.frmGuiaEntradaSaida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbGuia;
    }
}