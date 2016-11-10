namespace Apresentacao.Telas
{
    partial class frmPesagemEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesagemEntrada));
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMotorista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.dtpDataHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(10, 27);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(453, 21);
            this.cboCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(7, 11);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Motorista";
            // 
            // cboMotorista
            // 
            this.cboMotorista.FormattingEnabled = true;
            this.cboMotorista.Location = new System.Drawing.Point(10, 70);
            this.cboMotorista.Name = "cboMotorista";
            this.cboMotorista.Size = new System.Drawing.Size(453, 21);
            this.cboMotorista.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Veículo";
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(10, 113);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(453, 21);
            this.cboVeiculo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Operação";
            // 
            // cboOperacao
            // 
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.cboOperacao.Location = new System.Drawing.Point(10, 156);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(127, 21);
            this.cboOperacao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material";
            // 
            // cboMaterial
            // 
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(143, 156);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(320, 21);
            this.cboMaterial.TabIndex = 8;
            // 
            // dtpDataHoraEntrada
            // 
            this.dtpDataHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataHoraEntrada.Location = new System.Drawing.Point(10, 200);
            this.dtpDataHoraEntrada.Name = "dtpDataHoraEntrada";
            this.dtpDataHoraEntrada.Size = new System.Drawing.Size(127, 20);
            this.dtpDataHoraEntrada.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Hora Entrada";
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Location = new System.Drawing.Point(144, 199);
            this.txtPesoEntrada.Mask = "99999,99";
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.Size = new System.Drawing.Size(86, 20);
            this.txtPesoEntrada.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Peso Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(13, 244);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(450, 97);
            this.txtObservacoes.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(380, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(291, 347);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmPesagemEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(475, 376);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataHoraEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboOperacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMotorista);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesagemEntrada";
            this.Text = "Registrar entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.DateTimePicker dtpDataHoraEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPesoEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}