using System;

namespace Apresentacao.Telas
{
    partial class frmTipoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMaterial));
            this.gboxTipoMaterial = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.stAcoes = new System.Windows.Forms.ToolStrip();
            this.stbtIncluir = new System.Windows.Forms.ToolStripButton();
            this.stbtAlterar = new System.Windows.Forms.ToolStripButton();
            this.stbtExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvTipoMaterial = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo_string = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwTipoMaterialGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoBusca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.vw_TipoMaterial_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_TipoMaterial_GridTableAdapter();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.gboxTipoMaterial.SuspendLayout();
            this.gboxInfoControle.SuspendLayout();
            this.stAcoes.SuspendLayout();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoMaterialGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxTipoMaterial
            // 
            this.gboxTipoMaterial.Controls.Add(this.label6);
            this.gboxTipoMaterial.Controls.Add(this.txtCodigo);
            this.gboxTipoMaterial.Controls.Add(this.chkAtivo);
            this.gboxTipoMaterial.Controls.Add(this.label1);
            this.gboxTipoMaterial.Controls.Add(this.txtDescricao);
            this.gboxTipoMaterial.Location = new System.Drawing.Point(10, 64);
            this.gboxTipoMaterial.Name = "gboxTipoMaterial";
            this.gboxTipoMaterial.Size = new System.Drawing.Size(638, 119);
            this.gboxTipoMaterial.TabIndex = 0;
            this.gboxTipoMaterial.TabStop = false;
            this.gboxTipoMaterial.Text = "Tipo Material";
            this.gboxTipoMaterial.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(17, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(486, 46);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(118, 44);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(349, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // gboxInfoControle
            // 
            this.gboxInfoControle.Controls.Add(this.label4);
            this.gboxInfoControle.Controls.Add(this.txtDataAlteracao);
            this.gboxInfoControle.Controls.Add(this.label5);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioAlteracao);
            this.gboxInfoControle.Controls.Add(this.label3);
            this.gboxInfoControle.Controls.Add(this.txtDataInclusao);
            this.gboxInfoControle.Controls.Add(this.label2);
            this.gboxInfoControle.Controls.Add(this.txtUsuarioInclusao);
            this.gboxInfoControle.Location = new System.Drawing.Point(671, 64);
            this.gboxInfoControle.Name = "gboxInfoControle";
            this.gboxInfoControle.Size = new System.Drawing.Size(343, 118);
            this.gboxInfoControle.TabIndex = 1;
            this.gboxInfoControle.TabStop = false;
            this.gboxInfoControle.Text = "Informações de Controle";
            this.gboxInfoControle.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Alteração";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(189, 84);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(127, 20);
            this.txtDataAlteracao.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Usuário Alteração";
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(22, 84);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(151, 20);
            this.txtUsuarioAlteracao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Inclusão";
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.Location = new System.Drawing.Point(186, 34);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(130, 20);
            this.txtDataInclusao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário Inclusão";
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(19, 35);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 0;
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
            this.stAcoes.Size = new System.Drawing.Size(1057, 31);
            this.stAcoes.Stretch = true;
            this.stAcoes.TabIndex = 2;
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
            this.stbtIncluir.Text = "Inclui um Tipo de Material";
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
            this.stbtAlterar.Text = "Altera um Tipo de Material";
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
            this.stbtExcluir.Text = "Exclui um Tipo de Material";
            this.stbtExcluir.Click += new System.EventHandler(this.stbtExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(16, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(105, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dgvTipoMaterial);
            this.gboxDados.Location = new System.Drawing.Point(10, 267);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1035, 244);
            this.gboxDados.TabIndex = 7;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros: ";
            this.gboxDados.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvTipoMaterial
            // 
            this.dgvTipoMaterial.AllowUserToAddRows = false;
            this.dgvTipoMaterial.AutoGenerateColumns = false;
            this.dgvTipoMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.ativo_string,
            this.dataInclusao,
            this.usuarioInclusao,
            this.dataAlteracao,
            this.usuarioAlteracao,
            this.ativo});
            this.dgvTipoMaterial.DataSource = this.vwTipoMaterialGridBindingSource;
            this.dgvTipoMaterial.Location = new System.Drawing.Point(16, 21);
            this.dgvTipoMaterial.MultiSelect = false;
            this.dgvTipoMaterial.Name = "dgvTipoMaterial";
            this.dgvTipoMaterial.ReadOnly = true;
            this.dgvTipoMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoMaterial.Size = new System.Drawing.Size(1009, 206);
            this.dgvTipoMaterial.TabIndex = 6;
            this.dgvTipoMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoMaterial_CellContentClick_1);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 250;
            // 
            // ativo_string
            // 
            this.ativo_string.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ativo_string.DataPropertyName = "ativo_string";
            this.ativo_string.HeaderText = "Ativo";
            this.ativo_string.Name = "ativo_string";
            this.ativo_string.ReadOnly = true;
            // 
            // dataInclusao
            // 
            this.dataInclusao.DataPropertyName = "dataInclusao";
            this.dataInclusao.HeaderText = "Data Inclusão";
            this.dataInclusao.Name = "dataInclusao";
            this.dataInclusao.ReadOnly = true;
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
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Código";
            // 
            // txtCodigoBusca
            // 
            this.txtCodigoBusca.Location = new System.Drawing.Point(16, 241);
            this.txtCodigoBusca.Name = "txtCodigoBusca";
            this.txtCodigoBusca.Size = new System.Drawing.Size(95, 20);
            this.txtCodigoBusca.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Descrição";
            // 
            // txtDescricaoBusca
            // 
            this.txtDescricaoBusca.Location = new System.Drawing.Point(117, 241);
            this.txtDescricaoBusca.Name = "txtDescricaoBusca";
            this.txtDescricaoBusca.Size = new System.Drawing.Size(349, 20);
            this.txtDescricaoBusca.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(472, 241);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // vw_TipoMaterial_GridTableAdapter
            // 
            this.vw_TipoMaterial_GridTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(545, 241);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarTodos.TabIndex = 13;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // frmTipoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1057, 519);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoBusca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricaoBusca);
            this.Controls.Add(this.gboxDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.stAcoes);
            this.Controls.Add(this.gboxInfoControle);
            this.Controls.Add(this.gboxTipoMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo de Material";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmTipoMaterial_Load);
            this.gboxTipoMaterial.ResumeLayout(false);
            this.gboxTipoMaterial.PerformLayout();
            this.gboxInfoControle.ResumeLayout(false);
            this.gboxInfoControle.PerformLayout();
            this.stAcoes.ResumeLayout(false);
            this.stAcoes.PerformLayout();
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoMaterialGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvTipoMaterial_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvTipoMaterial.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = dgvTipoMaterial.Rows[e.RowIndex].Cells[1].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvTipoMaterial.Rows[e.RowIndex].Cells[7].Value.ToString()));
            txtDataInclusao.Text = dgvTipoMaterial.CurrentRow.Cells[3].Value.ToString();
            txtUsuarioInclusao.Text = dgvTipoMaterial.CurrentRow.Cells[4].Value.ToString();
            txtDataAlteracao.Text = dgvTipoMaterial.CurrentRow.Cells[5].Value.ToString();
            txtUsuarioAlteracao.Text = dgvTipoMaterial.CurrentRow.Cells[6].Value.ToString();
        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTipoMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gboxInfoControle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ToolStrip stAcoes;
        private System.Windows.Forms.ToolStripButton stbtIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwTipoMaterialGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_TipoMaterial_GridTableAdapter vw_TipoMaterial_GridTableAdapter;
        private System.Windows.Forms.ToolStripButton stbtAlterar;
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.DataGridView dgvTipoMaterial;
        private System.Windows.Forms.ToolStripButton stbtExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo_string;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricaoBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarTodos;

    }
}

