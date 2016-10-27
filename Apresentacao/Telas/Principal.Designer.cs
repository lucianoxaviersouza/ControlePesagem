namespace Apresentacao.Telas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePesagemEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePesagemSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pesagemToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoMaterialToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.motoristasToolStripMenuItem,
            this.veículosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tipoMaterialToolStripMenuItem
            // 
            this.tipoMaterialToolStripMenuItem.Name = "tipoMaterialToolStripMenuItem";
            this.tipoMaterialToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tipoMaterialToolStripMenuItem.Text = "Tipo Material";
            this.tipoMaterialToolStripMenuItem.Click += new System.EventHandler(this.tipoMaterialToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // motoristasToolStripMenuItem
            // 
            this.motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            this.motoristasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.motoristasToolStripMenuItem.Text = "Motoristas";
            this.motoristasToolStripMenuItem.Click += new System.EventHandler(this.motoristasToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // pesagemToolStripMenuItem
            // 
            this.pesagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePesagemEntradaToolStripMenuItem,
            this.registroDePesagemSaídaToolStripMenuItem});
            this.pesagemToolStripMenuItem.Name = "pesagemToolStripMenuItem";
            this.pesagemToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pesagemToolStripMenuItem.Text = "Pesagem";
            // 
            // registroDePesagemEntradaToolStripMenuItem
            // 
            this.registroDePesagemEntradaToolStripMenuItem.Name = "registroDePesagemEntradaToolStripMenuItem";
            this.registroDePesagemEntradaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registroDePesagemEntradaToolStripMenuItem.Text = "Registro de Pesagem - Entrada";
            this.registroDePesagemEntradaToolStripMenuItem.Click += new System.EventHandler(this.registroDePesagemEntradaToolStripMenuItem_Click);
            // 
            // registroDePesagemSaídaToolStripMenuItem
            // 
            this.registroDePesagemSaídaToolStripMenuItem.Name = "registroDePesagemSaídaToolStripMenuItem";
            this.registroDePesagemSaídaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registroDePesagemSaídaToolStripMenuItem.Text = "Registro de Pesagem - Saída";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 512);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Controle de Pesagem - versão 1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePesagemEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePesagemSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}