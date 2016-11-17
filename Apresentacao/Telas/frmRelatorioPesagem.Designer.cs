namespace Apresentacao.Telas
{
    partial class frmRelatorioPesagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioPesagem));
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gboxDados = new System.Windows.Forms.GroupBox();
            this.dgvPesagem = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPesagemConsultaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.vw_PesagemConsulta_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webRelatorio = new System.Windows.Forms.WebBrowser();
            this.gboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(689, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Material";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(502, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Motorista";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(249, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(140, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Código";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Data Pesagem";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(878, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(692, 31);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 20);
            this.textBox8.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(505, 31);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 20);
            this.textBox7.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(252, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 20);
            this.textBox5.TabIndex = 23;
            // 
            // gboxDados
            // 
            this.gboxDados.Controls.Add(this.webRelatorio);
            this.gboxDados.Controls.Add(this.dgvPesagem);
            this.gboxDados.Location = new System.Drawing.Point(7, 65);
            this.gboxDados.Name = "gboxDados";
            this.gboxDados.Size = new System.Drawing.Size(1207, 385);
            this.gboxDados.TabIndex = 22;
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
            this.codigoDataGridViewTextBoxColumn,
            this.dataHoraEntradaDataGridViewTextBoxColumn,
            this.dataHoraSaidaDataGridViewTextBoxColumn,
            this.pesoEntradaDataGridViewTextBoxColumn,
            this.pesoSaidaDataGridViewTextBoxColumn,
            this.pesoTotalDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.dataInclusaoDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn,
            this.usuarioInclusaoDataGridViewTextBoxColumn,
            this.usuarioAlteracaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvPesagem.DataSource = this.vwPesagemConsultaGridBindingSource;
            this.dgvPesagem.Location = new System.Drawing.Point(18, 19);
            this.dgvPesagem.MultiSelect = false;
            this.dgvPesagem.Name = "dgvPesagem";
            this.dgvPesagem.ReadOnly = true;
            this.dgvPesagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesagem.Size = new System.Drawing.Size(1177, 350);
            this.dgvPesagem.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraEntradaDataGridViewTextBoxColumn
            // 
            this.dataHoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "dataHoraEntrada";
            this.dataHoraEntradaDataGridViewTextBoxColumn.HeaderText = "dataHoraEntrada";
            this.dataHoraEntradaDataGridViewTextBoxColumn.Name = "dataHoraEntradaDataGridViewTextBoxColumn";
            this.dataHoraEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraSaidaDataGridViewTextBoxColumn
            // 
            this.dataHoraSaidaDataGridViewTextBoxColumn.DataPropertyName = "dataHoraSaida";
            this.dataHoraSaidaDataGridViewTextBoxColumn.HeaderText = "dataHoraSaida";
            this.dataHoraSaidaDataGridViewTextBoxColumn.Name = "dataHoraSaidaDataGridViewTextBoxColumn";
            this.dataHoraSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoEntradaDataGridViewTextBoxColumn
            // 
            this.pesoEntradaDataGridViewTextBoxColumn.DataPropertyName = "pesoEntrada";
            this.pesoEntradaDataGridViewTextBoxColumn.HeaderText = "pesoEntrada";
            this.pesoEntradaDataGridViewTextBoxColumn.Name = "pesoEntradaDataGridViewTextBoxColumn";
            this.pesoEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoSaidaDataGridViewTextBoxColumn
            // 
            this.pesoSaidaDataGridViewTextBoxColumn.DataPropertyName = "pesoSaida";
            this.pesoSaidaDataGridViewTextBoxColumn.HeaderText = "pesoSaida";
            this.pesoSaidaDataGridViewTextBoxColumn.Name = "pesoSaidaDataGridViewTextBoxColumn";
            this.pesoSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoTotalDataGridViewTextBoxColumn
            // 
            this.pesoTotalDataGridViewTextBoxColumn.DataPropertyName = "pesoTotal";
            this.pesoTotalDataGridViewTextBoxColumn.HeaderText = "pesoTotal";
            this.pesoTotalDataGridViewTextBoxColumn.Name = "pesoTotalDataGridViewTextBoxColumn";
            this.pesoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "motorista";
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            this.motoristaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInclusaoDataGridViewTextBoxColumn
            // 
            this.dataInclusaoDataGridViewTextBoxColumn.DataPropertyName = "dataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.HeaderText = "dataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.Name = "dataInclusaoDataGridViewTextBoxColumn";
            this.dataInclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioInclusaoDataGridViewTextBoxColumn
            // 
            this.usuarioInclusaoDataGridViewTextBoxColumn.DataPropertyName = "usuarioInclusao";
            this.usuarioInclusaoDataGridViewTextBoxColumn.HeaderText = "usuarioInclusao";
            this.usuarioInclusaoDataGridViewTextBoxColumn.Name = "usuarioInclusaoDataGridViewTextBoxColumn";
            this.usuarioInclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioAlteracaoDataGridViewTextBoxColumn
            // 
            this.usuarioAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "usuarioAlteracao";
            this.usuarioAlteracaoDataGridViewTextBoxColumn.HeaderText = "usuarioAlteracao";
            this.usuarioAlteracaoDataGridViewTextBoxColumn.Name = "usuarioAlteracaoDataGridViewTextBoxColumn";
            this.usuarioAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwPesagemConsultaGridBindingSource
            // 
            this.vwPesagemConsultaGridBindingSource.DataMember = "vw_PesagemConsulta_Grid";
            this.vwPesagemConsultaGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // controlePesagemDataSet
            // 
            this.controlePesagemDataSet.DataSetName = "ControlePesagemDataSet";
            this.controlePesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_PesagemConsulta_GridTableAdapter
            // 
            this.vw_PesagemConsulta_GridTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(950, 29);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTodos.TabIndex = 34;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1083, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Imprimir Resultado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webRelatorio
            // 
            this.webRelatorio.Location = new System.Drawing.Point(81, -22);
            this.webRelatorio.MinimumSize = new System.Drawing.Size(20, 20);
            this.webRelatorio.Name = "webRelatorio";
            this.webRelatorio.Size = new System.Drawing.Size(998, 342);
            this.webRelatorio.TabIndex = 36;
            this.webRelatorio.Visible = false;
            // 
            // frmRelatorioPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1230, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.gboxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioPesagem";
            this.Text = "Relatório de Pesagem - Entradas e Saída";
            this.Load += new System.EventHandler(this.frmRelatorioPesagem_Load);
            this.gboxDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gboxDados;
        private System.Windows.Forms.DataGridView dgvPesagem;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwPesagemConsultaGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter vw_PesagemConsulta_GridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webRelatorio;
    }
}