namespace Apresentacao.Telas
{
    partial class frmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculo));
            this.gboxCampos = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.vwClienteGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.vwVeiculoGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.stAcoes = new System.Windows.Forms.ToolStrip();
            this.stbtIncluir = new System.Windows.Forms.ToolStripButton();
            this.stbtAlterar = new System.Windows.Forms.ToolStripButton();
            this.stbtExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vw_Veiculo_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Veiculo_GridTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.cboClienteBusca = new System.Windows.Forms.ComboBox();
            this.vwClienteGridBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.vwVeiculoGridBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Cliente_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter();
            this.txtPlacaBusca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo_string = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocialCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasiaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource)).BeginInit();
            this.gboxInfoControle.SuspendLayout();
            this.stAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxCampos
            // 
            this.gboxCampos.Controls.Add(this.label10);
            this.gboxCampos.Controls.Add(this.cboCliente);
            this.gboxCampos.Controls.Add(this.chkAtivo);
            this.gboxCampos.Controls.Add(this.txtCor);
            this.gboxCampos.Controls.Add(this.label8);
            this.gboxCampos.Controls.Add(this.txtPlaca);
            this.gboxCampos.Controls.Add(this.label7);
            this.gboxCampos.Controls.Add(this.txtModelo);
            this.gboxCampos.Controls.Add(this.label6);
            this.gboxCampos.Controls.Add(this.txtCodigo);
            this.gboxCampos.Controls.Add(this.label5);
            this.gboxCampos.Location = new System.Drawing.Point(12, 39);
            this.gboxCampos.Name = "gboxCampos";
            this.gboxCampos.Size = new System.Drawing.Size(739, 120);
            this.gboxCampos.TabIndex = 0;
            this.gboxCampos.TabStop = false;
            this.gboxCampos.Text = "Veiculo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCliente.DataSource = this.vwClienteGridBindingSource;
            this.cboCliente.DisplayMember = "nomeFantasia";
            this.cboCliente.Enabled = false;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(129, 41);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(596, 21);
            this.cboCliente.TabIndex = 11;
            this.cboCliente.ValueMember = "codigo";
            // 
            // vwClienteGridBindingSource
            // 
            this.vwClienteGridBindingSource.DataMember = "vw_Cliente_Grid";
            this.vwClienteGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // controlePesagemDataSet
            // 
            this.controlePesagemDataSet.DataSetName = "ControlePesagemDataSet";
            this.controlePesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(674, 84);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 10;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCor
            // 
            this.txtCor.Enabled = false;
            this.txtCor.Location = new System.Drawing.Point(553, 82);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(115, 20);
            this.txtCor.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cor";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(414, 83);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(133, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Placa";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(20, 83);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(388, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Modelo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dgvVeiculo);
            this.gboxDados.Location = new System.Drawing.Point(12, 253);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1223, 265);
            this.gboxDados.TabIndex = 1;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros: ";
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.AllowUserToAddRows = false;
            this.dgvVeiculo.AllowUserToDeleteRows = false;
            this.dgvVeiculo.AllowUserToOrderColumns = true;
            this.dgvVeiculo.AutoGenerateColumns = false;
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.placa,
            this.modelo,
            this.cor,
            this.ativo_string,
            this.RazaoSocialCliente,
            this.NomeFantasiaCliente,
            this.usuarioInclusao,
            this.dataInclusao,
            this.usuarioAlteracao,
            this.dataAlteracao,
            this.ativo});
            this.dgvVeiculo.DataSource = this.vwVeiculoGridBindingSource;
            this.dgvVeiculo.Location = new System.Drawing.Point(7, 20);
            this.dgvVeiculo.MultiSelect = false;
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.ReadOnly = true;
            this.dgvVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculo.ShowCellErrors = false;
            this.dgvVeiculo.ShowCellToolTips = false;
            this.dgvVeiculo.ShowEditingIcon = false;
            this.dgvVeiculo.ShowRowErrors = false;
            this.dgvVeiculo.Size = new System.Drawing.Size(1194, 239);
            this.dgvVeiculo.TabIndex = 0;
            this.dgvVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculo_CellContentClick);
            // 
            // vwVeiculoGridBindingSource
            // 
            this.vwVeiculoGridBindingSource.DataMember = "vw_Veiculo_Grid";
            this.vwVeiculoGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // gboxInfoControle
            // 
            this.gboxInfoControle.Controls.Add(this.label4);
            this.gboxInfoControle.Controls.Add(this.label3);
            this.gboxInfoControle.Controls.Add(this.label2);
            this.gboxInfoControle.Controls.Add(this.label1);
            this.gboxInfoControle.Controls.Add(this.txtDataAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtDataInclusao);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioInclusao);
            this.gboxInfoControle.Location = new System.Drawing.Point(757, 39);
            this.gboxInfoControle.Name = "gboxInfoControle";
            this.gboxInfoControle.Size = new System.Drawing.Size(334, 120);
            this.gboxInfoControle.TabIndex = 1;
            this.gboxInfoControle.TabStop = false;
            this.gboxInfoControle.Text = "Informações de Controle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Alteração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário Alteração";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Inclusão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário Inclusão";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(185, 82);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(130, 20);
            this.txtDataAlteracao.TabIndex = 3;
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.Location = new System.Drawing.Point(185, 42);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(130, 20);
            this.txtDataInclusao.TabIndex = 2;
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(15, 82);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioAlteracao.TabIndex = 1;
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(15, 42);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 0;
            // 
            // stAcoes
            // 
            this.stAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbtIncluir,
            this.stbtAlterar,
            this.stbtExcluir});
            this.stAcoes.Location = new System.Drawing.Point(0, 0);
            this.stAcoes.Name = "stAcoes";
            this.stAcoes.Size = new System.Drawing.Size(1244, 31);
            this.stAcoes.TabIndex = 2;
            // 
            // stbtIncluir
            // 
            this.stbtIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtIncluir.Image = ((System.Drawing.Image)(resources.GetObject("stbtIncluir.Image")));
            this.stbtIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbtIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtIncluir.Name = "stbtIncluir";
            this.stbtIncluir.Size = new System.Drawing.Size(28, 28);
            this.stbtIncluir.Text = "Incluir";
            this.stbtIncluir.Click += new System.EventHandler(this.stbtIncluir_Click);
            // 
            // stbtAlterar
            // 
            this.stbtAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtAlterar.Image = ((System.Drawing.Image)(resources.GetObject("stbtAlterar.Image")));
            this.stbtAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbtAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtAlterar.Name = "stbtAlterar";
            this.stbtAlterar.Size = new System.Drawing.Size(28, 28);
            this.stbtAlterar.Text = "Alterar";
            this.stbtAlterar.Click += new System.EventHandler(this.stbtAlterar_Click);
            // 
            // stbtExcluir
            // 
            this.stbtExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtExcluir.Image = ((System.Drawing.Image)(resources.GetObject("stbtExcluir.Image")));
            this.stbtExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbtExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtExcluir.Name = "stbtExcluir";
            this.stbtExcluir.Size = new System.Drawing.Size(28, 28);
            this.stbtExcluir.Text = "Excluir";
            this.stbtExcluir.Click += new System.EventHandler(this.stbtExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(16, 167);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(105, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // vw_Veiculo_GridTableAdapter
            // 
            this.vw_Veiculo_GridTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cliente";
            // 
            // cboClienteBusca
            // 
            this.cboClienteBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboClienteBusca.DataSource = this.vwClienteGridBindingSource1;
            this.cboClienteBusca.DisplayMember = "nomeFantasia";
            this.cboClienteBusca.FormattingEnabled = true;
            this.cboClienteBusca.Location = new System.Drawing.Point(19, 223);
            this.cboClienteBusca.Name = "cboClienteBusca";
            this.cboClienteBusca.Size = new System.Drawing.Size(328, 21);
            this.cboClienteBusca.TabIndex = 17;
            this.cboClienteBusca.ValueMember = "codigo";
            // 
            // vwClienteGridBindingSource1
            // 
            this.vwClienteGridBindingSource1.DataMember = "vw_Cliente_Grid";
            this.vwClienteGridBindingSource1.DataSource = this.controlePesagemDataSet;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(565, 223);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarTodos.TabIndex = 20;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(492, 223);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // vwVeiculoGridBindingSource1
            // 
            this.vwVeiculoGridBindingSource1.DataMember = "vw_Veiculo_Grid";
            this.vwVeiculoGridBindingSource1.DataSource = this.controlePesagemDataSet;
            // 
            // vw_Cliente_GridTableAdapter
            // 
            this.vw_Cliente_GridTableAdapter.ClearBeforeFill = true;
            // 
            // txtPlacaBusca
            // 
            this.txtPlacaBusca.Enabled = false;
            this.txtPlacaBusca.Location = new System.Drawing.Point(353, 224);
            this.txtPlacaBusca.Name = "txtPlacaBusca";
            this.txtPlacaBusca.Size = new System.Drawing.Size(133, 20);
            this.txtPlacaBusca.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Placa";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 250;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "cor";
            this.cor.HeaderText = "Cor";
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            // 
            // ativo_string
            // 
            this.ativo_string.DataPropertyName = "ativo_string";
            this.ativo_string.HeaderText = "Ativo";
            this.ativo_string.Name = "ativo_string";
            this.ativo_string.ReadOnly = true;
            // 
            // RazaoSocialCliente
            // 
            this.RazaoSocialCliente.DataPropertyName = "RazaoSocialCliente";
            this.RazaoSocialCliente.HeaderText = "Razão Social Cliente";
            this.RazaoSocialCliente.Name = "RazaoSocialCliente";
            this.RazaoSocialCliente.ReadOnly = true;
            this.RazaoSocialCliente.Width = 250;
            // 
            // NomeFantasiaCliente
            // 
            this.NomeFantasiaCliente.DataPropertyName = "NomeFantasiaCliente";
            this.NomeFantasiaCliente.HeaderText = "Nome Fantasia Cliente";
            this.NomeFantasiaCliente.Name = "NomeFantasiaCliente";
            this.NomeFantasiaCliente.ReadOnly = true;
            this.NomeFantasiaCliente.Width = 200;
            // 
            // usuarioInclusao
            // 
            this.usuarioInclusao.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusao.HeaderText = "Usuário Inclusão";
            this.usuarioInclusao.Name = "usuarioInclusao";
            this.usuarioInclusao.ReadOnly = true;
            this.usuarioInclusao.Visible = false;
            // 
            // dataInclusao
            // 
            this.dataInclusao.DataPropertyName = "dataInclusao";
            this.dataInclusao.HeaderText = "Data Inclusão";
            this.dataInclusao.Name = "dataInclusao";
            this.dataInclusao.ReadOnly = true;
            this.dataInclusao.Visible = false;
            // 
            // usuarioAlteracao
            // 
            this.usuarioAlteracao.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracao.HeaderText = "Usuário Alteração";
            this.usuarioAlteracao.Name = "usuarioAlteracao";
            this.usuarioAlteracao.ReadOnly = true;
            this.usuarioAlteracao.Visible = false;
            // 
            // dataAlteracao
            // 
            this.dataAlteracao.DataPropertyName = "dataAlteracao";
            this.dataAlteracao.HeaderText = "Data Alteração";
            this.dataAlteracao.Name = "dataAlteracao";
            this.dataAlteracao.ReadOnly = true;
            this.dataAlteracao.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1244, 571);
            this.Controls.Add(this.txtPlacaBusca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboClienteBusca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.stAcoes);
            this.Controls.Add(this.gboxInfoControle);
            this.Controls.Add(this.gboxDados);
            this.Controls.Add(this.gboxCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVeiculo";
            this.Text = "Cadastro de Veiculo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.gboxCampos.ResumeLayout(false);
            this.gboxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource)).EndInit();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.stAcoes.ResumeLayout(false);
            this.stAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCampos;
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.GroupBox gboxInfoControle;
        private System.Windows.Forms.ToolStrip stAcoes;
        private System.Windows.Forms.ToolStripButton stbtIncluir;
        private System.Windows.Forms.ToolStripButton stbtAlterar;
        private System.Windows.Forms.ToolStripButton stbtExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DataGridView dgvVeiculo;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwVeiculoGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Veiculo_GridTableAdapter vw_Veiculo_GridTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboClienteBusca;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource vwVeiculoGridBindingSource1;
        private System.Windows.Forms.BindingSource vwClienteGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter vw_Cliente_GridTableAdapter;
        private System.Windows.Forms.BindingSource vwClienteGridBindingSource1;
        private System.Windows.Forms.TextBox txtPlacaBusca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo_string;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocialCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasiaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
    }
}