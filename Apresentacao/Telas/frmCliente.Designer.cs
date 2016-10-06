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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gboxInfoControle = new System.Windows.Forms.GroupBox();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwClienteGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.stAcoes = new System.Windows.Forms.ToolStrip();
            this.stbtIncluir = new System.Windows.Forms.ToolStripButton();
            this.stbtAlterar = new System.Windows.Forms.ToolStripButton();
            this.stbtExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vw_Cliente_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataInclusao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.gboxCliente.SuspendLayout();
            this.gboxInfoControle.SuspendLayout();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.stAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCliente
            // 
            this.gboxCliente.Controls.Add(this.label1);
            this.gboxCliente.Controls.Add(this.textBox1);
            this.gboxCliente.Location = new System.Drawing.Point(12, 39);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Size = new System.Drawing.Size(728, 119);
            this.gboxCliente.TabIndex = 0;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
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
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.dataGridView1);
            this.gboxDados.Location = new System.Drawing.Point(12, 205);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1223, 265);
            this.gboxDados.TabIndex = 2;
            this.gboxDados.TabStop = false;
            this.gboxDados.Text = "Registros: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.telefone1DataGridViewTextBoxColumn,
            this.telefone2DataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn,
            this.dataInclusaoDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn,
            this.usuarioInclusaoDataGridViewTextBoxColumn,
            this.usuarioAlteracaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwClienteGridBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1172, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "razaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "razaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "nomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "nomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            this.telefone1DataGridViewTextBoxColumn.DataPropertyName = "telefone1";
            this.telefone1DataGridViewTextBoxColumn.HeaderText = "telefone1";
            this.telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            // 
            // telefone2DataGridViewTextBoxColumn
            // 
            this.telefone2DataGridViewTextBoxColumn.DataPropertyName = "telefone2";
            this.telefone2DataGridViewTextBoxColumn.HeaderText = "telefone2";
            this.telefone2DataGridViewTextBoxColumn.Name = "telefone2DataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "ativo";
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            // 
            // dataInclusaoDataGridViewTextBoxColumn
            // 
            this.dataInclusaoDataGridViewTextBoxColumn.DataPropertyName = "dataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.HeaderText = "dataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.Name = "dataInclusaoDataGridViewTextBoxColumn";
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            // 
            // usuarioInclusaoDataGridViewTextBoxColumn
            // 
            this.usuarioInclusaoDataGridViewTextBoxColumn.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusaoDataGridViewTextBoxColumn.HeaderText = "usuarioInclusao";
            this.usuarioInclusaoDataGridViewTextBoxColumn.Name = "usuarioInclusaoDataGridViewTextBoxColumn";
            // 
            // usuarioAlteracaoDataGridViewTextBoxColumn
            // 
            this.usuarioAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracaoDataGridViewTextBoxColumn.HeaderText = "usuarioAlteracao";
            this.usuarioAlteracaoDataGridViewTextBoxColumn.Name = "usuarioAlteracaoDataGridViewTextBoxColumn";
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(105, 165);
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
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(15, 42);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(154, 20);
            this.txtUsuarioInclusao.TabIndex = 0;
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
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1244, 482);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwClienteGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter vw_Cliente_GridTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataInclusao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioAlteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
    }
}