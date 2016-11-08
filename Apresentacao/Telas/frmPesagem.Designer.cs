namespace Apresentacao.Telas
{
    partial class frmPesagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesagem));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarEntrada = new System.Windows.Forms.ToolStripButton();
            this.gboxRegistroPesagemConsolidado = new System.Windows.Forms.GroupBox();
            this.btnRegistrarSaida = new System.Windows.Forms.ToolStripButton();
            this.txtClienteConsulta = new System.Windows.Forms.TextBox();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotoristaConsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeiculoConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoOperacaoConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterialConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataHoraEntradaConsulta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataHoraSaidaConsulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.gboxRegistroPesagemConsolidado.SuspendLayout();
            this.gboxInfoControle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarEntrada,
            this.btnRegistrarSaida});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1086, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrarEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEntrada.Image")));
            this.btnRegistrarEntrada.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRegistrarEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(52, 52);
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // gboxRegistroPesagemConsolidado
            // 
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label10);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.textBox3);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.groupBox1);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label9);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.textBox2);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label8);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.textBox1);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label7);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtDataHoraSaidaConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label6);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtDataHoraEntradaConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label5);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtMaterialConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label4);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtTipoOperacaoConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label3);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtVeiculoConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label2);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtMotoristaConsulta);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.label1);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.gboxInfoControle);
            this.gboxRegistroPesagemConsolidado.Controls.Add(this.txtClienteConsulta);
            this.gboxRegistroPesagemConsolidado.Location = new System.Drawing.Point(12, 72);
            this.gboxRegistroPesagemConsolidado.Name = "gboxRegistroPesagemConsolidado";
            this.gboxRegistroPesagemConsolidado.Size = new System.Drawing.Size(1048, 359);
            this.gboxRegistroPesagemConsolidado.TabIndex = 1;
            this.gboxRegistroPesagemConsolidado.TabStop = false;
            this.gboxRegistroPesagemConsolidado.Text = "Registro de Pesagem";
            // 
            // btnRegistrarSaida
            // 
            this.btnRegistrarSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrarSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarSaida.Image")));
            this.btnRegistrarSaida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRegistrarSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarSaida.Name = "btnRegistrarSaida";
            this.btnRegistrarSaida.Size = new System.Drawing.Size(52, 52);
            this.btnRegistrarSaida.Text = "Registrar Saída";
            // 
            // txtClienteConsulta
            // 
            this.txtClienteConsulta.Enabled = false;
            this.txtClienteConsulta.Location = new System.Drawing.Point(18, 41);
            this.txtClienteConsulta.Name = "txtClienteConsulta";
            this.txtClienteConsulta.Size = new System.Drawing.Size(660, 20);
            this.txtClienteConsulta.TabIndex = 0;
            // 
            // gboxInfoControle
            // 
            this.gboxInfoControle.Controls.Add(this.label15);
            this.gboxInfoControle.Controls.Add(this.textBox4);
            this.gboxInfoControle.Controls.Add(this.label11);
            this.gboxInfoControle.Controls.Add(this.label12);
            this.gboxInfoControle.Controls.Add(this.label13);
            this.gboxInfoControle.Controls.Add(this.label14);
            this.gboxInfoControle.Controls.Add(this.txtDataAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtDataInclusao);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioInclusao);
            this.gboxInfoControle.Location = new System.Drawing.Point(702, 19);
            this.gboxInfoControle.Name = "gboxInfoControle";
            this.gboxInfoControle.Size = new System.Drawing.Size(323, 169);
            this.gboxInfoControle.TabIndex = 1;
            this.gboxInfoControle.TabStop = false;
            this.gboxInfoControle.Text = "Informações de Controle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motorista";
            // 
            // txtMotoristaConsulta
            // 
            this.txtMotoristaConsulta.Enabled = false;
            this.txtMotoristaConsulta.Location = new System.Drawing.Point(18, 83);
            this.txtMotoristaConsulta.Name = "txtMotoristaConsulta";
            this.txtMotoristaConsulta.Size = new System.Drawing.Size(327, 20);
            this.txtMotoristaConsulta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veículo";
            // 
            // txtVeiculoConsulta
            // 
            this.txtVeiculoConsulta.Enabled = false;
            this.txtVeiculoConsulta.Location = new System.Drawing.Point(360, 83);
            this.txtVeiculoConsulta.Name = "txtVeiculoConsulta";
            this.txtVeiculoConsulta.Size = new System.Drawing.Size(318, 20);
            this.txtVeiculoConsulta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Operação";
            // 
            // txtTipoOperacaoConsulta
            // 
            this.txtTipoOperacaoConsulta.Enabled = false;
            this.txtTipoOperacaoConsulta.Location = new System.Drawing.Point(18, 125);
            this.txtTipoOperacaoConsulta.Name = "txtTipoOperacaoConsulta";
            this.txtTipoOperacaoConsulta.Size = new System.Drawing.Size(164, 20);
            this.txtTipoOperacaoConsulta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material";
            // 
            // txtMaterialConsulta
            // 
            this.txtMaterialConsulta.Enabled = false;
            this.txtMaterialConsulta.Location = new System.Drawing.Point(197, 125);
            this.txtMaterialConsulta.Name = "txtMaterialConsulta";
            this.txtMaterialConsulta.Size = new System.Drawing.Size(481, 20);
            this.txtMaterialConsulta.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Hora - Entrada";
            // 
            // txtDataHoraEntradaConsulta
            // 
            this.txtDataHoraEntradaConsulta.Enabled = false;
            this.txtDataHoraEntradaConsulta.Location = new System.Drawing.Point(18, 168);
            this.txtDataHoraEntradaConsulta.Name = "txtDataHoraEntradaConsulta";
            this.txtDataHoraEntradaConsulta.Size = new System.Drawing.Size(164, 20);
            this.txtDataHoraEntradaConsulta.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Hora - Saída";
            // 
            // txtDataHoraSaidaConsulta
            // 
            this.txtDataHoraSaidaConsulta.Enabled = false;
            this.txtDataHoraSaidaConsulta.Location = new System.Drawing.Point(18, 211);
            this.txtDataHoraSaidaConsulta.Name = "txtDataHoraSaidaConsulta";
            this.txtDataHoraSaidaConsulta.Size = new System.Drawing.Size(164, 20);
            this.txtDataHoraSaidaConsulta.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Peso - Entrada (Kilos)";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(197, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Peso - Saída (Kilos)";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(197, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPesoTotal);
            this.groupBox1.Location = new System.Drawing.Point(384, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 70);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peso Total";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblPesoTotal.Location = new System.Drawing.Point(14, 24);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(112, 31);
            this.lblPesoTotal.TabIndex = 0;
            this.lblPesoTotal.Text = "9999,99";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(18, 260);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(1007, 93);
            this.textBox3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Observações";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Data Alteração";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Data Inclusão";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Usuário Inclusão";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(183, 89);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(130, 20);
            this.txtDataAlteracao.TabIndex = 11;
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.Location = new System.Drawing.Point(183, 49);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(130, 20);
            this.txtDataInclusao.TabIndex = 10;
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(13, 49);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 8;
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(13, 89);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioAlteracao.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Usuário Alteração";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Status";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(17, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(296, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1086, 788);
            this.Controls.Add(this.gboxRegistroPesagemConsolidado);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Entrada e Saída - Pesagem";
            this.Load += new System.EventHandler(this.frmPesagem_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gboxRegistroPesagemConsolidado.ResumeLayout(false);
            this.gboxRegistroPesagemConsolidado.PerformLayout();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegistrarEntrada;
        private System.Windows.Forms.GroupBox gboxRegistroPesagemConsolidado;
        private System.Windows.Forms.ToolStripButton btnRegistrarSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxInfoControle;
        private System.Windows.Forms.TextBox txtClienteConsulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataHoraSaidaConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataHoraEntradaConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterialConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoOperacaoConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVeiculoConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotoristaConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
    }
}