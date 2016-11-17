namespace Apresentacao.Telas
{
    partial class frmMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterial));
            this.stAcoes = new System.Windows.Forms.ToolStrip();
            this.stbtIncluir = new System.Windows.Forms.ToolStripButton();
            this.stbtAlterar = new System.Windows.Forms.ToolStripButton();
            this.stbtExcluir = new System.Windows.Forms.ToolStripButton();
            this.gboxCampos = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoMaterial = new System.Windows.Forms.ComboBox();
            this.vwTipoMaterialGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo_string = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTipoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTipoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwMaterialGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Material_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter();
            this.vw_TipoMaterial_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_TipoMaterial_GridTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoBusca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTipoMaterialBusca = new System.Windows.Forms.ComboBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.stAcoes.SuspendLayout();
            this.gboxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoMaterialGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.gboxInfoControle.SuspendLayout();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stAcoes
            // 
            this.stAcoes.BackColor = System.Drawing.Color.LightGray;
            this.stAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbtIncluir,
            this.stbtAlterar,
            this.stbtExcluir});
            this.stAcoes.Location = new System.Drawing.Point(0, 0);
            this.stAcoes.Name = "stAcoes";
            this.stAcoes.Size = new System.Drawing.Size(1244, 31);
            this.stAcoes.TabIndex = 0;
            this.stAcoes.Text = "toolStrip1";
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
            this.stbtAlterar.Text = "toolStripButton2";
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
            this.stbtExcluir.Text = "toolStripButton3";
            this.stbtExcluir.Click += new System.EventHandler(this.stbtExcluir_Click);
            // 
            // gboxCampos
            // 
            this.gboxCampos.Controls.Add(this.chkAtivo);
            this.gboxCampos.Controls.Add(this.label7);
            this.gboxCampos.Controls.Add(this.label6);
            this.gboxCampos.Controls.Add(this.txtDescricao);
            this.gboxCampos.Controls.Add(this.txtCodigo);
            this.gboxCampos.Controls.Add(this.label5);
            this.gboxCampos.Controls.Add(this.cboTipoMaterial);
            this.gboxCampos.Location = new System.Drawing.Point(12, 39);
            this.gboxCampos.Name = "gboxCampos";
            this.gboxCampos.Size = new System.Drawing.Size(507, 120);
            this.gboxCampos.TabIndex = 1;
            this.gboxCampos.TabStop = false;
            this.gboxCampos.Text = "Material";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(392, 43);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Código";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(12, 89);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(430, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Material";
            // 
            // cboTipoMaterial
            // 
            this.cboTipoMaterial.DataSource = this.vwTipoMaterialGridBindingSource;
            this.cboTipoMaterial.DisplayMember = "descricao";
            this.cboTipoMaterial.Enabled = false;
            this.cboTipoMaterial.FormattingEnabled = true;
            this.cboTipoMaterial.Location = new System.Drawing.Point(134, 42);
            this.cboTipoMaterial.Name = "cboTipoMaterial";
            this.cboTipoMaterial.Size = new System.Drawing.Size(243, 21);
            this.cboTipoMaterial.TabIndex = 0;
            this.cboTipoMaterial.ValueMember = "codigo";
            // 
            // vwTipoMaterialGridBindingSource
            // 
            this.vwTipoMaterialGridBindingSource.DataMember = "vw_TipoMaterial_Grid";
            this.vwTipoMaterialGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // controlePesagemDataSet
            // 
            this.controlePesagemDataSet.DataSetName = "ControlePesagemDataSet";
            this.controlePesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gboxInfoControle
            // 
            this.gboxInfoControle.Controls.Add(this.txtUsuarioAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtDataAlteracao);
            this.gboxInfoControle.Controls.Add(this.txtDataInclusao);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioInclusao);
            this.gboxInfoControle.Controls.Add(this.label4);
            this.gboxInfoControle.Controls.Add(this.label3);
            this.gboxInfoControle.Controls.Add(this.label2);
            this.gboxInfoControle.Controls.Add(this.label1);
            this.gboxInfoControle.Location = new System.Drawing.Point(538, 39);
            this.gboxInfoControle.Name = "gboxInfoControle";
            this.gboxInfoControle.Size = new System.Drawing.Size(334, 120);
            this.gboxInfoControle.TabIndex = 2;
            this.gboxInfoControle.TabStop = false;
            this.gboxInfoControle.Text = "Informações de Controle";
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(15, 88);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioAlteracao.TabIndex = 7;
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(185, 88);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(130, 20);
            this.txtDataAlteracao.TabIndex = 6;
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.Location = new System.Drawing.Point(185, 42);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(130, 20);
            this.txtDataInclusao.TabIndex = 5;
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(15, 42);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Alteração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Inclusão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário Alteração";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário Inclusão";
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dgvMaterial);
            this.gboxDados.Location = new System.Drawing.Point(12, 251);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1223, 265);
            this.gboxDados.TabIndex = 3;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros: ";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.AllowUserToDeleteRows = false;
            this.dgvMaterial.AllowUserToOrderColumns = true;
            this.dgvMaterial.AutoGenerateColumns = false;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.ativo_string,
            this.descricaoTipoMaterial,
            this.dataInclusao,
            this.usuarioInclusao,
            this.dataAlteracao,
            this.usuarioAlteracao,
            this.codigoTipoMaterial,
            this.ativo});
            this.dgvMaterial.DataSource = this.vwMaterialGridBindingSource;
            this.dgvMaterial.Location = new System.Drawing.Point(21, 19);
            this.dgvMaterial.MultiSelect = false;
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.ReadOnly = true;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(1172, 226);
            this.dgvMaterial.TabIndex = 0;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.FillWeight = 250F;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 250;
            // 
            // ativo_string
            // 
            this.ativo_string.DataPropertyName = "ativo_string";
            this.ativo_string.HeaderText = "Ativo?";
            this.ativo_string.Name = "ativo_string";
            this.ativo_string.ReadOnly = true;
            // 
            // descricaoTipoMaterial
            // 
            this.descricaoTipoMaterial.DataPropertyName = "descricaoTipoMaterial";
            this.descricaoTipoMaterial.FillWeight = 250F;
            this.descricaoTipoMaterial.HeaderText = "Tipo";
            this.descricaoTipoMaterial.Name = "descricaoTipoMaterial";
            this.descricaoTipoMaterial.ReadOnly = true;
            this.descricaoTipoMaterial.Width = 250;
            // 
            // dataInclusao
            // 
            this.dataInclusao.DataPropertyName = "dataInclusao";
            this.dataInclusao.HeaderText = "Data Inclusão";
            this.dataInclusao.Name = "dataInclusao";
            this.dataInclusao.ReadOnly = true;
            this.dataInclusao.Width = 150;
            // 
            // usuarioInclusao
            // 
            this.usuarioInclusao.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusao.HeaderText = "Usuário Inclusão";
            this.usuarioInclusao.Name = "usuarioInclusao";
            this.usuarioInclusao.ReadOnly = true;
            this.usuarioInclusao.Width = 150;
            // 
            // dataAlteracao
            // 
            this.dataAlteracao.DataPropertyName = "dataAlteracao";
            this.dataAlteracao.HeaderText = "Data Alteração";
            this.dataAlteracao.Name = "dataAlteracao";
            this.dataAlteracao.ReadOnly = true;
            this.dataAlteracao.Width = 150;
            // 
            // usuarioAlteracao
            // 
            this.usuarioAlteracao.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracao.HeaderText = "Usuário Alteração";
            this.usuarioAlteracao.Name = "usuarioAlteracao";
            this.usuarioAlteracao.ReadOnly = true;
            this.usuarioAlteracao.Width = 150;
            // 
            // codigoTipoMaterial
            // 
            this.codigoTipoMaterial.DataPropertyName = "codigoTipoMaterial";
            this.codigoTipoMaterial.HeaderText = "codigoTipoMaterial";
            this.codigoTipoMaterial.Name = "codigoTipoMaterial";
            this.codigoTipoMaterial.ReadOnly = true;
            this.codigoTipoMaterial.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // vwMaterialGridBindingSource
            // 
            this.vwMaterialGridBindingSource.DataMember = "vw_Material_Grid";
            this.vwMaterialGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // vw_Material_GridTableAdapter
            // 
            this.vw_Material_GridTableAdapter.ClearBeforeFill = true;
            // 
            // vw_TipoMaterial_GridTableAdapter
            // 
            this.vw_TipoMaterial_GridTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(16, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(105, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Descrição";
            // 
            // txtDescricaoBusca
            // 
            this.txtDescricaoBusca.Location = new System.Drawing.Point(273, 219);
            this.txtDescricaoBusca.MaxLength = 100;
            this.txtDescricaoBusca.Name = "txtDescricaoBusca";
            this.txtDescricaoBusca.Size = new System.Drawing.Size(430, 20);
            this.txtDescricaoBusca.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tipo Material";
            // 
            // cboTipoMaterialBusca
            // 
            this.cboTipoMaterialBusca.DataSource = this.vwTipoMaterialGridBindingSource;
            this.cboTipoMaterialBusca.DisplayMember = "descricao";
            this.cboTipoMaterialBusca.FormattingEnabled = true;
            this.cboTipoMaterialBusca.Location = new System.Drawing.Point(24, 219);
            this.cboTipoMaterialBusca.Name = "cboTipoMaterialBusca";
            this.cboTipoMaterialBusca.Size = new System.Drawing.Size(243, 21);
            this.cboTipoMaterialBusca.TabIndex = 6;
            this.cboTipoMaterialBusca.ValueMember = "codigo";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(786, 217);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTodos.TabIndex = 11;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(714, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1244, 526);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricaoBusca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboTipoMaterialBusca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gboxDados);
            this.Controls.Add(this.gboxInfoControle);
            this.Controls.Add(this.gboxCampos);
            this.Controls.Add(this.stAcoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Materiais";
            this.Load += new System.EventHandler(this.frmMaterial_Load);
            this.stAcoes.ResumeLayout(false);
            this.stAcoes.PerformLayout();
            this.gboxCampos.ResumeLayout(false);
            this.gboxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoMaterialGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip stAcoes;
        private System.Windows.Forms.ToolStripButton stbtIncluir;
        private System.Windows.Forms.ToolStripButton stbtAlterar;
        private System.Windows.Forms.ToolStripButton stbtExcluir;
        private System.Windows.Forms.GroupBox gboxCampos;
        private System.Windows.Forms.GroupBox gboxInfoControle;
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwMaterialGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter vw_Material_GridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo_string;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoTipoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private ControlePesagemDataSetTableAdapters.vw_TipoMaterial_GridTableAdapter vw_TipoMaterial_GridTableAdapter;
        private System.Windows.Forms.ComboBox cboTipoMaterial;
        private System.Windows.Forms.BindingSource vwTipoMaterialGridBindingSource;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricaoBusca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTipoMaterialBusca;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
    }
}