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
    public partial class frmPesagemSaida : Form
    {

        private Pesagem pesagem;
        public frmPesagem frmPesagemGlobal;

        public frmPesagemSaida()
        {
            InitializeComponent();
        }
        public frmPesagemSaida(frmPesagem frmPesagemPrincipal, int codigoPesagem )
        {
            frmPesagemGlobal = frmPesagemPrincipal;

            PesagemBus p = new PesagemBus();
            pesagem = p.buscarPorCodigo(codigoPesagem);

            InitializeComponent();
        }

        private void frmPesagemSaida_Load(object sender, EventArgs e)
        {


            txtCodigo.Text = pesagem.codigo.ToString();
            txtCliente.Text = pesagem.cliente.Codigo + " - " + pesagem.cliente.NomeFantasia;
            txtMotorista.Text = pesagem.motorista.Codigo + " - " + pesagem.motorista.nomeConhecido;
            txtVeiculo.Text = pesagem.veiculo.Codigo + " - " + pesagem.veiculo.Placa + " - " + pesagem.veiculo.Modelo + " - " + pesagem.veiculo.Cor;
            txtOperacao.Text = pesagem.tipoOperacao;
            txtMaterial.Text = pesagem.material.Codigo + " - " + pesagem.material.Descricao;
            txtDataHoraEntrada.Text = pesagem.dataHoraEntrada.ToString();
            txtPesoEntrada.Text = pesagem.pesoEntrada.ToString();
            dtpDataHoraSaida.Format = DateTimePickerFormat.Custom;
            dtpDataHoraSaida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDataHoraSaida.Value = DateTime.Now;
            //txtPesoSaida.Text = pesagem.pesoSaida.ToString();
            txtObservacoes.Text = pesagem.observacoes;


        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (pesagem.dataHoraEntrada > dtpDataHoraSaida.Value)
            { 
                  MessageBox.Show("A data e hora de saída deve ser maior que a data e hora de entrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }

            if (txtPesoSaida.Text == "")
            {
                MessageBox.Show("O peso de saída deve ser informado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Pesagem objPesagem = new Pesagem();
                PesagemBus p = new PesagemBus();

                objPesagem.codigo = Convert.ToInt16(txtCodigo.Text);
                objPesagem.dataHoraSaida = Convert.ToDateTime(dtpDataHoraSaida.Text);
                objPesagem.pesoSaida = Convert.ToDecimal(txtPesoSaida.Text);
                objPesagem.status = "Concluída";
                objPesagem.observacoes = txtObservacoes.Text;

                objPesagem.UsuarioAlteracao = Principal.usuario;
                objPesagem.DataAlteracao = DateTime.Now;
                p.alterar(objPesagem);
                MessageBox.Show("Pesagem concluída com sucesso!");
                frmPesagemGlobal.vw_PesagemConsulta_GridTableAdapter.Fill(frmPesagemGlobal.controlePesagemDataSet.vw_PesagemConsulta_Grid);
                this.Close();

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

            frmPesagemGlobal.vw_PesagemConsulta_GridTableAdapter.Fill(frmPesagemGlobal.controlePesagemDataSet.vw_PesagemConsulta_Grid);
            this.Close();

        }

    }
}
