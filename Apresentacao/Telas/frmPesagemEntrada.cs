using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao.Util;
using Apresentacao.Telas;
using Entidade;
using Negocio;
using Apresentacao;


namespace Apresentacao.Telas
{
    public partial class frmPesagemEntrada : Form
    {
        public frmPesagem frmPesagemGlobal;

        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao
        {
            registrarEntrada, registrarSaida
        };

        public frmPesagemEntrada()
        {
            InitializeComponent();
        }

        public frmPesagemEntrada(frmPesagem p)
        {
            InitializeComponent();
            frmPesagemGlobal = p;
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesagem objPesagem = new Pesagem();
                PesagemBus pesagem = new PesagemBus();

                objPesagem.cliente.Codigo = Convert.ToInt16(cboCliente.SelectedValue.ToString());
                objPesagem.motorista.Codigo = Convert.ToInt16(cboMotorista.SelectedValue.ToString());
                objPesagem.veiculo.Codigo = Convert.ToInt16(cboVeiculo.SelectedValue.ToString());
                objPesagem.material.Codigo = Convert.ToInt16(cboMaterial.SelectedValue.ToString());
                objPesagem.tipoOperacao = cboOperacao.Text;
                objPesagem.dataHoraEntrada = Convert.ToDateTime(dtpDataHoraEntrada.Text);
                objPesagem.pesoEntrada = Convert.ToDecimal(txtPesoEntrada.Text);
                objPesagem.status = "Em andamento";
                objPesagem.observacoes = txtObservacoes.Text;

                if (globalTipoAcao.Equals(enunTipoAcao.registrarEntrada))
                {
                    objPesagem.UsuarioInclusao = Principal.usuario;
                    objPesagem.DataInclusao = DateTime.Now;
                    pesagem.inserir(objPesagem);
                    MessageBox.Show("Registro Inserido com sucesso!");
                    frmPesagemGlobal.vw_PesagemConsulta_GridTableAdapter.Fill(frmPesagemGlobal.controlePesagemDataSet.vw_PesagemConsulta_Grid);
                    this.Close();
                }
                
                

            }
            catch (Exception ex)
            {

                if (ex is System.Data.SqlClient.SqlException)
                {
                    System.Data.SqlClient.SqlException erro = (System.Data.SqlClient.SqlException)ex;

                    MessageBox.Show("Erro inesperado ao realizar a inclusão no banco de dados. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Erro inesperado ao realizar a inclusão. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void frmPesagemEntrada_Load(object sender, EventArgs e)
        {

            this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
            this.vw_Material_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Material_Grid);
            this.vw_Motorista_GridTableAdapter.FillByCodigoCliente(this.controlePesagemDataSet.vw_Motorista_Grid, ((int)(System.Convert.ChangeType(cboCliente.SelectedValue, typeof(int)))));
            this.vw_Veiculo_GridTableAdapter.FillByCodigoCliente(this.controlePesagemDataSet.vw_Veiculo_Grid, ((int)(System.Convert.ChangeType(cboCliente.SelectedValue, typeof(int)))));

            dtpDataHoraEntrada.Format = DateTimePickerFormat.Custom;
            dtpDataHoraEntrada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDataHoraEntrada.Value = DateTime.Now;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vw_Motorista_GridTableAdapter.FillByCodigoCliente(this.controlePesagemDataSet.vw_Motorista_Grid, ((int)(System.Convert.ChangeType(cboCliente.SelectedValue, typeof(int)))));
            this.vw_Veiculo_GridTableAdapter.FillByCodigoCliente(this.controlePesagemDataSet.vw_Veiculo_Grid, ((int)(System.Convert.ChangeType(cboCliente.SelectedValue, typeof(int)))));
        }

        
    }
}
