﻿namespace Apresentacao.Telas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesagem));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarEntrada = new System.Windows.Forms.ToolStripButton();
            this.btnRegistrarSaida = new System.Windows.Forms.ToolStripButton();
            this.gboxRegistroPesagemConsolidado = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataHoraSaidaConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataHoraEntradaConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterialConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoOperacaoConsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeiculoConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotoristaConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.txtClienteConsulta = new System.Windows.Forms.TextBox();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvPesagem = new System.Windows.Forms.DataGridView();
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.vwPesagemConsultaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_PesagemConsulta_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gboxRegistroPesagemConsolidado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxInfoControle.SuspendLayout();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).BeginInit();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Observações";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Data Alteração";
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
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(13, 89);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioAlteracao.TabIndex = 9;
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(13, 49);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 8;
            // 
            // txtClienteConsulta
            // 
            this.txtClienteConsulta.Enabled = false;
            this.txtClienteConsulta.Location = new System.Drawing.Point(18, 41);
            this.txtClienteConsulta.Name = "txtClienteConsulta";
            this.txtClienteConsulta.Size = new System.Drawing.Size(660, 20);
            this.txtClienteConsulta.TabIndex = 0;
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dgvPesagem);
            this.gboxDados.Location = new System.Drawing.Point(12, 495);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1048, 283);
            this.gboxDados.TabIndex = 2;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros:";
            // 
            // dgvPesagem
            // 
            this.dgvPesagem.AllowUserToAddRows = false;
            this.dgvPesagem.AllowUserToDeleteRows = false;
            this.dgvPesagem.AllowUserToResizeRows = false;
            this.dgvPesagem.AutoGenerateColumns = false;
            this.dgvPesagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dataHoraEntrada,
            this.dataHoraSaida,
            this.Cliente,
            this.veiculo,
            this.motorista,
            this.material,
            this.pesoEntrada,
            this.pesoSaida,
            this.pesoTotal,
            this.dataInclusao,
            this.dataAlteracao,
            this.usuarioInclusaoDataGridViewTextBoxColumn,
            this.usuarioAlteracao,
            this.status});
            this.dgvPesagem.DataSource = this.vwPesagemConsultaGridBindingSource;
            this.dgvPesagem.Location = new System.Drawing.Point(18, 19);
            this.dgvPesagem.MultiSelect = false;
            this.dgvPesagem.Name = "dgvPesagem";
            this.dgvPesagem.ReadOnly = true;
            this.dgvPesagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesagem.Size = new System.Drawing.Size(1007, 244);
            this.dgvPesagem.TabIndex = 0;
            // 
            // controlePesagemDataSet
            // 
            this.controlePesagemDataSet.DataSetName = "ControlePesagemDataSet";
            this.controlePesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwPesagemConsultaGridBindingSource
            // 
            this.vwPesagemConsultaGridBindingSource.DataMember = "vw_PesagemConsulta_Grid";
            this.vwPesagemConsultaGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // vw_PesagemConsulta_GridTableAdapter
            // 
            this.vw_PesagemConsulta_GridTableAdapter.ClearBeforeFill = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // dataHoraEntrada
            // 
            this.dataHoraEntrada.DataPropertyName = "dataHoraEntrada";
            this.dataHoraEntrada.HeaderText = "Data Hora - Entrada";
            this.dataHoraEntrada.Name = "dataHoraEntrada";
            this.dataHoraEntrada.ReadOnly = true;
            // 
            // dataHoraSaida
            // 
            this.dataHoraSaida.DataPropertyName = "dataHoraSaida";
            this.dataHoraSaida.HeaderText = "Data Hora - Saída";
            this.dataHoraSaida.Name = "dataHoraSaida";
            this.dataHoraSaida.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // veiculo
            // 
            this.veiculo.DataPropertyName = "veiculo";
            this.veiculo.HeaderText = "Veículo";
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            // 
            // motorista
            // 
            this.motorista.DataPropertyName = "motorista";
            this.motorista.HeaderText = "Motorista";
            this.motorista.Name = "motorista";
            this.motorista.ReadOnly = true;
            // 
            // material
            // 
            this.material.DataPropertyName = "material";
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // pesoEntrada
            // 
            this.pesoEntrada.DataPropertyName = "pesoEntrada";
            this.pesoEntrada.HeaderText = "Peso Entrada";
            this.pesoEntrada.Name = "pesoEntrada";
            this.pesoEntrada.ReadOnly = true;
            // 
            // pesoSaida
            // 
            this.pesoSaida.DataPropertyName = "pesoSaida";
            this.pesoSaida.HeaderText = "Peso Saída";
            this.pesoSaida.Name = "pesoSaida";
            this.pesoSaida.ReadOnly = true;
            // 
            // pesoTotal
            // 
            this.pesoTotal.DataPropertyName = "pesoTotal";
            this.pesoTotal.HeaderText = "Peso Total";
            this.pesoTotal.Name = "pesoTotal";
            this.pesoTotal.ReadOnly = true;
            // 
            // dataInclusao
            // 
            this.dataInclusao.DataPropertyName = "dataInclusao";
            this.dataInclusao.HeaderText = "Data Inclusão";
            this.dataInclusao.Name = "dataInclusao";
            this.dataInclusao.ReadOnly = true;
            // 
            // dataAlteracao
            // 
            this.dataAlteracao.DataPropertyName = "dataAlteracao";
            this.dataAlteracao.HeaderText = "Data Alteração";
            this.dataAlteracao.Name = "dataAlteracao";
            this.dataAlteracao.ReadOnly = true;
            // 
            // usuarioInclusaoDataGridViewTextBoxColumn
            // 
            this.usuarioInclusaoDataGridViewTextBoxColumn.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusaoDataGridViewTextBoxColumn.HeaderText = "Usuário Inclusão";
            this.usuarioInclusaoDataGridViewTextBoxColumn.Name = "usuarioInclusaoDataGridViewTextBoxColumn";
            this.usuarioInclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioAlteracao
            // 
            this.usuarioAlteracao.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracao.HeaderText = "Usuário  Alteração";
            this.usuarioAlteracao.Name = "usuarioAlteracao";
            this.usuarioAlteracao.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 461);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(257, 461);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 20);
            this.textBox6.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 461);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(510, 461);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(697, 461);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 20);
            this.textBox8.TabIndex = 7;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(953, 460);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTodos.TabIndex = 13;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(883, 459);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Data Entrada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 445);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Código";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(254, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Cliente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(507, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Motorista";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(694, 445);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Material";
            // 
            // frmPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1086, 788);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.gboxDados);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.DataGridView dgvPesagem;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwPesagemConsultaGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter vw_PesagemConsulta_GridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}