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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesagemEntrada));
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.vwClienteGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePesagemDataSet = new Apresentacao.ControlePesagemDataSet();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMotorista = new System.Windows.Forms.ComboBox();
            this.vwMotoristaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.vwVeiculoGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.vwMaterialGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.vw_Cliente_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter();
            this.vw_Motorista_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Motorista_GridTableAdapter();
            this.vw_Veiculo_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Veiculo_GridTableAdapter();
            this.vw_Material_GridTableAdapter = new Apresentacao.ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter();
            this.txtPesoEntrada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMotoristaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = this.vwClienteGridBindingSource;
            this.cboCliente.DisplayMember = "nomeFantasia";
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(10, 27);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(453, 21);
            this.cboCliente.TabIndex = 0;
            this.cboCliente.ValueMember = "codigo";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
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
            this.cboMotorista.DataSource = this.vwMotoristaGridBindingSource;
            this.cboMotorista.DisplayMember = "nomeConhecido";
            this.cboMotorista.FormattingEnabled = true;
            this.cboMotorista.Location = new System.Drawing.Point(10, 70);
            this.cboMotorista.Name = "cboMotorista";
            this.cboMotorista.Size = new System.Drawing.Size(453, 21);
            this.cboMotorista.TabIndex = 2;
            this.cboMotorista.ValueMember = "codigo";
            // 
            // vwMotoristaGridBindingSource
            // 
            this.vwMotoristaGridBindingSource.DataMember = "vw_Motorista_Grid";
            this.vwMotoristaGridBindingSource.DataSource = this.controlePesagemDataSet;
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
            this.cboVeiculo.DataSource = this.vwVeiculoGridBindingSource;
            this.cboVeiculo.DisplayMember = "placa";
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(10, 113);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(453, 21);
            this.cboVeiculo.TabIndex = 4;
            this.cboVeiculo.ValueMember = "codigo";
            // 
            // vwVeiculoGridBindingSource
            // 
            this.vwVeiculoGridBindingSource.DataMember = "vw_Veiculo_Grid";
            this.vwVeiculoGridBindingSource.DataSource = this.controlePesagemDataSet;
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
            "Venda",
            "Pesagem de Lixo"});
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
            this.cboMaterial.DataSource = this.vwMaterialGridBindingSource;
            this.cboMaterial.DisplayMember = "descricao";
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(143, 156);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(320, 21);
            this.cboMaterial.TabIndex = 8;
            this.cboMaterial.ValueMember = "codigo";
            // 
            // vwMaterialGridBindingSource
            // 
            this.vwMaterialGridBindingSource.DataMember = "vw_Material_Grid";
            this.vwMaterialGridBindingSource.DataSource = this.controlePesagemDataSet;
            // 
            // dtpDataHoraEntrada
            // 
            this.dtpDataHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataHoraEntrada.Location = new System.Drawing.Point(10, 200);
            this.dtpDataHoraEntrada.Name = "dtpDataHoraEntrada";
            this.dtpDataHoraEntrada.Size = new System.Drawing.Size(150, 20);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 184);
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
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(380, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
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
            // vw_Cliente_GridTableAdapter
            // 
            this.vw_Cliente_GridTableAdapter.ClearBeforeFill = true;
            // 
            // vw_Motorista_GridTableAdapter
            // 
            this.vw_Motorista_GridTableAdapter.ClearBeforeFill = true;
            // 
            // vw_Veiculo_GridTableAdapter
            // 
            this.vw_Veiculo_GridTableAdapter.ClearBeforeFill = true;
            // 
            // vw_Material_GridTableAdapter
            // 
            this.vw_Material_GridTableAdapter.ClearBeforeFill = true;
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Location = new System.Drawing.Point(166, 203);
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.Size = new System.Drawing.Size(120, 20);
            this.txtPesoEntrada.TabIndex = 18;
            // 
            // frmPesagemEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(483, 390);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Load += new System.EventHandler(this.frmPesagemEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePesagemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMotoristaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVeiculoGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialGridBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private ControlePesagemDataSet controlePesagemDataSet;
        private System.Windows.Forms.BindingSource vwClienteGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Cliente_GridTableAdapter vw_Cliente_GridTableAdapter;
        private System.Windows.Forms.BindingSource vwMotoristaGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Motorista_GridTableAdapter vw_Motorista_GridTableAdapter;
        private System.Windows.Forms.BindingSource vwVeiculoGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Veiculo_GridTableAdapter vw_Veiculo_GridTableAdapter;
        private System.Windows.Forms.BindingSource vwMaterialGridBindingSource;
        private ControlePesagemDataSetTableAdapters.vw_Material_GridTableAdapter vw_Material_GridTableAdapter;
        private System.Windows.Forms.TextBox txtPesoEntrada;
    }
}