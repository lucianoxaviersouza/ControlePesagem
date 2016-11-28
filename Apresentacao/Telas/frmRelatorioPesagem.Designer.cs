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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_PesagemConsulta_GridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoBusca = new System.Windows.Forms.TextBox();
            this.vwPesagemConsultaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_PesagemConsulta_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.vwMaterialGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Material_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter();
            this.dtpDataPesagem = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vw_PesagemConsulta_GridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_PesagemConsulta_GridBindingSource
            // 
            this.vw_PesagemConsulta_GridBindingSource.DataMember = "vw_PesagemConsulta_Grid";
            this.vw_PesagemConsulta_GridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // controlePesagemDataSet
            // 
            this.controlePesagemDataSet.DataSetName = "ControlePesagemDataSet";
            this.controlePesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label16.Location = new System.Drawing.Point(9, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Data Pesagem";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(983, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMotorista
            // 
            this.txtMotorista.Location = new System.Drawing.Point(505, 31);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(180, 20);
            this.txtMotorista.TabIndex = 26;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(252, 31);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(246, 20);
            this.txtCliente.TabIndex = 24;
            // 
            // txtCodigoBusca
            // 
            this.txtCodigoBusca.Location = new System.Drawing.Point(141, 31);
            this.txtCodigoBusca.Name = "txtCodigoBusca";
            this.txtCodigoBusca.Size = new System.Drawing.Size(105, 20);
            this.txtCodigoBusca.TabIndex = 23;
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
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTodos.Image")));
            this.btnBuscarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTodos.Location = new System.Drawing.Point(1055, 28);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTodos.TabIndex = 34;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_PesagemConsulta_GridBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.Telas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1816, 624);
            this.reportViewer1.TabIndex = 36;
            // 
            // cboMaterial
            // 
            this.cboMaterial.DataSource = this.vwMaterialGridBindingSource;
            this.cboMaterial.DisplayMember = "descricao";
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(692, 30);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(275, 21);
            this.cboMaterial.TabIndex = 37;
            this.cboMaterial.ValueMember = "codigo";
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
            // dtpDataPesagem
            // 
            this.dtpDataPesagem.Location = new System.Drawing.Point(12, 31);
            this.dtpDataPesagem.Mask = "00/00/0000";
            this.dtpDataPesagem.Name = "dtpDataPesagem";
            this.dtpDataPesagem.Size = new System.Drawing.Size(100, 20);
            this.dtpDataPesagem.TabIndex = 38;
            this.dtpDataPesagem.ValidatingType = typeof(System.DateTime);
            // 
            // frmRelatorioPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1840, 694);
            this.Controls.Add(this.dtpDataPesagem);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMotorista);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigoBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioPesagem";
            this.Text = "Relatório de Pesagem - Entradas e Saídas";
            this.Load += new System.EventHandler(this.frmRelatorioPesagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_PesagemConsulta_GridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPesagemConsultaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigoBusca;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwPesagemConsultaGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_PesagemConsulta_GridTableAdapter vw_PesagemConsulta_GridTableAdapter;
        private System.Windows.Forms.Button btnBuscarTodos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_PesagemConsulta_GridBindingSource;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.BindingSource vwMaterialGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter vw_Material_GridTableAdapter;
        private System.Windows.Forms.MaskedTextBox dtpDataPesagem;
    }
}