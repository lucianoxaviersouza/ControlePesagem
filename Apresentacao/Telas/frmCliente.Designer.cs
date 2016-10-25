namespace Apresentacao.Telas
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.gboxCliente = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.vwClienteGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.stAcoes = new System.Windows.Forms.ToolStrip();
            this.stbtIncluir = new System.Windows.Forms.ToolStripButton();
            this.stbtAlterar = new System.Windows.Forms.ToolStripButton();
            this.stbtExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vw_Cliente_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter();
            this.txtCNPJBusca = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeFantasiaBusca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodigoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo_string = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxCliente.SuspendLayout();
            this.gboxInfoControle.SuspendLayout();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.stAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCliente
            // 
            this.gboxCliente.Controls.Add(this.chkAtivo);
            this.gboxCliente.Controls.Add(this.label11);
            this.gboxCliente.Controls.Add(this.txtEmail);
            this.gboxCliente.Controls.Add(this.txtTelefone2);
            this.gboxCliente.Controls.Add(this.label10);
            this.gboxCliente.Controls.Add(this.txtTelefone1);
            this.gboxCliente.Controls.Add(this.label9);
            this.gboxCliente.Controls.Add(this.txtCNPJ);
            this.gboxCliente.Controls.Add(this.label8);
            this.gboxCliente.Controls.Add(this.label7);
            this.gboxCliente.Controls.Add(this.txtNomeFantasia);
            this.gboxCliente.Controls.Add(this.label6);
            this.gboxCliente.Controls.Add(this.txtRazaoSocial);
            this.gboxCliente.Controls.Add(this.label1);
            this.gboxCliente.Controls.Add(this.txtCodigo);
            this.gboxCliente.Location = new System.Drawing.Point(12, 39);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Size = new System.Drawing.Size(728, 154);
            this.gboxCliente.TabIndex = 0;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Cliente";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(664, 39);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(233, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(481, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Enabled = false;
            this.txtTelefone2.Location = new System.Drawing.Point(127, 119);
            this.txtTelefone2.Mask = "(99) 0000-0000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefone";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Enabled = false;
            this.txtTelefone1.Location = new System.Drawing.Point(21, 119);
            this.txtTelefone1.Mask = "(99) 0000-0000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefone Principal";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(596, 78);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(118, 20);
            this.txtCNPJ.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CNPJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome Fantasia";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Enabled = false;
            this.txtNomeFantasia.Location = new System.Drawing.Point(21, 78);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(569, 20);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(127, 36);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(523, 20);
            this.txtRazaoSocial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // gboxInfoControle
            // 
            this.gboxInfoControle.Controls.Add(this.label5);
            this.gboxInfoControle.Controls.Add(this.txtDataAlteracao);
            this.gboxInfoControle.Controls.Add(this.label4);
            this.gboxInfoControle.Controls.Add(this.txtDataInclusao);
            this.gboxInfoControle.Controls.Add(this.label3);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioAlteracao);
            this.gboxInfoControle.Controls.Add(this.label2);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioInclusao);
            this.gboxInfoControle.Location = new System.Drawing.Point(746, 39);
            this.gboxInfoControle.Name = "gboxInfoControle";
            this.gboxInfoControle.Size = new System.Drawing.Size(334, 119);
            this.gboxInfoControle.TabIndex = 1;
            this.gboxInfoControle.TabStop = false;
            this.gboxInfoControle.Text = "Informações de Controle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Alteração";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(185, 88);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(130, 20);
            this.txtDataAlteracao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Inclusão";
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.Location = new System.Drawing.Point(185, 42);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(130, 20);
            this.txtDataInclusao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário Alteração";
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(15, 88);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioAlteracao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário Inclusão";
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(15, 42);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 0;
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dgvCliente);
            this.gboxDados.Location = new System.Drawing.Point(12, 277);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1223, 265);
            this.gboxDados.TabIndex = 2;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros: ";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AutoGenerateColumns = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.razaoSocial,
            this.nomeFantasia,
            this.cnpj,
            this.telefone1,
            this.email,
            this.ativo_string,
            this.telefone2,
            this.dataInclusao,
            this.usuarioInclusao,
            this.dataAlteracao,
            this.usuarioAlteracao,
            this.ativo});
            this.dgvCliente.DataSource = this.vwClienteGridBindingSource;
            this.dgvCliente.Location = new System.Drawing.Point(21, 19);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1186, 231);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
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
            // stAcoes
            // 
            this.stAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbtIncluir,
            this.stbtAlterar,
            this.stbtExcluir});
            this.stAcoes.Location = new System.Drawing.Point(0, 0);
            this.stAcoes.Name = "stAcoes";
            this.stAcoes.Size = new System.Drawing.Size(1244, 31);
            this.stAcoes.TabIndex = 3;
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
            this.stbtIncluir.Text = "toolStripButton1";
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
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(33, 199);
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
            this.btnCancelar.Location = new System.Drawing.Point(122, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // vw_Cliente_GridTableAdapter
            // 
            this.vw_Cliente_GridTableAdapter.ClearBeforeFill = true;
            // 
            // txtCNPJBusca
            // 
            this.txtCNPJBusca.Enabled = false;
            this.txtCNPJBusca.Location = new System.Drawing.Point(463, 251);
            this.txtCNPJBusca.Mask = "00.000.000/0000-00";
            this.txtCNPJBusca.Name = "txtCNPJBusca";
            this.txtCNPJBusca.Size = new System.Drawing.Size(118, 20);
            this.txtCNPJBusca.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "CNPJ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nome Fantasia";
            // 
            // txtNomeFantasiaBusca
            // 
            this.txtNomeFantasiaBusca.Enabled = false;
            this.txtNomeFantasiaBusca.Location = new System.Drawing.Point(139, 251);
            this.txtNomeFantasiaBusca.Name = "txtNomeFantasiaBusca";
            this.txtNomeFantasiaBusca.Size = new System.Drawing.Size(318, 20);
            this.txtNomeFantasiaBusca.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Código";
            // 
            // txtCodigoBusca
            // 
            this.txtCodigoBusca.Enabled = false;
            this.txtCodigoBusca.Location = new System.Drawing.Point(33, 251);
            this.txtCodigoBusca.Name = "txtCodigoBusca";
            this.txtCodigoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBusca.TabIndex = 9;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Enabled = false;
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(667, 249);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarTodos.TabIndex = 16;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(587, 249);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // razaoSocial
            // 
            this.razaoSocial.DataPropertyName = "razaoSocial";
            this.razaoSocial.FillWeight = 200F;
            this.razaoSocial.HeaderText = "Razão Social";
            this.razaoSocial.Name = "razaoSocial";
            this.razaoSocial.ReadOnly = true;
            this.razaoSocial.Width = 220;
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.DataPropertyName = "nomeFantasia";
            this.nomeFantasia.HeaderText = "Nome Fantasia";
            this.nomeFantasia.Name = "nomeFantasia";
            this.nomeFantasia.ReadOnly = true;
            this.nomeFantasia.Width = 250;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            // 
            // telefone1
            // 
            this.telefone1.DataPropertyName = "telefone1";
            this.telefone1.HeaderText = "Telefone Principal ";
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 250;
            // 
            // ativo_string
            // 
            this.ativo_string.DataPropertyName = "ativo_string";
            this.ativo_string.HeaderText = "Ativo";
            this.ativo_string.Name = "ativo_string";
            this.ativo_string.ReadOnly = true;
            // 
            // telefone2
            // 
            this.telefone2.DataPropertyName = "telefone2";
            this.telefone2.HeaderText = "telefone2";
            this.telefone2.Name = "telefone2";
            this.telefone2.ReadOnly = true;
            this.telefone2.Visible = false;
            // 
            // dataInclusao
            // 
            this.dataInclusao.DataPropertyName = "dataInclusao";
            this.dataInclusao.HeaderText = "dataInclusao";
            this.dataInclusao.Name = "dataInclusao";
            this.dataInclusao.ReadOnly = true;
            this.dataInclusao.Visible = false;
            // 
            // usuarioInclusao
            // 
            this.usuarioInclusao.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusao.HeaderText = "usuarioInclusao";
            this.usuarioInclusao.Name = "usuarioInclusao";
            this.usuarioInclusao.ReadOnly = true;
            this.usuarioInclusao.Visible = false;
            // 
            // dataAlteracao
            // 
            this.dataAlteracao.DataPropertyName = "dataAlteracao";
            this.dataAlteracao.HeaderText = "dataAlteracao";
            this.dataAlteracao.Name = "dataAlteracao";
            this.dataAlteracao.ReadOnly = true;
            this.dataAlteracao.Visible = false;
            // 
            // usuarioAlteracao
            // 
            this.usuarioAlteracao.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracao.HeaderText = "usuarioAlteracao";
            this.usuarioAlteracao.Name = "usuarioAlteracao";
            this.usuarioAlteracao.ReadOnly = true;
            this.usuarioAlteracao.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1244, 548);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCNPJBusca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNomeFantasiaBusca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCodigoBusca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.stAcoes);
            this.Controls.Add(this.gboxDados);
            this.Controls.Add(this.gboxInfoControle);
            this.Controls.Add(this.gboxCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gboxCliente.ResumeLayout(false);
            this.gboxCliente.PerformLayout();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            this.stAcoes.ResumeLayout(false);
            this.stAcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCliente;
        private System.Windows.Forms.GroupBox gboxInfoControle;
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.ToolStrip stAcoes;
        private System.Windows.Forms.ToolStripButton stbtIncluir;
        private System.Windows.Forms.ToolStripButton stbtAlterar;
        private System.Windows.Forms.ToolStripButton stbtExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.DataGridView dgvCliente;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwClienteGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter vw_Cliente_GridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo_string;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.MaskedTextBox txtCNPJBusca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeFantasiaBusca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodigoBusca;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
    }
}