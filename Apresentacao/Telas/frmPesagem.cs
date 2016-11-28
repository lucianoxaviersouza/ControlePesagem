using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Telas
{
    public partial class frmPesagem : Form
    {
        public frmPesagem()
        {
            InitializeComponent();
        }

        private void frmPesagem_Load(object sender, EventArgs e)
        {

            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);

            dgvPesagem.Sort(dgvPesagem.Columns["dataHoraEntrada"], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvPesagem.RowCount);


        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            frmPesagemEntrada pesagemEntrada = new frmPesagemEntrada(this);
            this.Enabled = false;
            pesagemEntrada.StartPosition = FormStartPosition.CenterScreen;
            pesagemEntrada.ShowDialog();
            this.Enabled = true;
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            if (txtCodigoConsulta.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para realizar a pesagem de saída!");
                return;
            }

            if (txtStatus.Text.Equals("Concluída"))
            {
                MessageBox.Show("Pesagem já concluída!");
                return;
            }

            
            int codigoPesagem = Convert.ToInt16(txtCodigoConsulta.Text);
            frmPesagemSaida pesagemSaida = new frmPesagemSaida(this,codigoPesagem);

            this.Enabled = false;
            pesagemSaida.StartPosition = FormStartPosition.CenterScreen;
            pesagemSaida.ShowDialog();
            this.Enabled = true;

        }

        private void dgvPesagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodigoConsulta.Text = dgvPesagem.CurrentRow.Cells["codigo"].Value.ToString();
            txtDataHoraEntradaConsulta.Text = dgvPesagem.CurrentRow.Cells["dataHoraEntrada"].Value.ToString();
            txtDataHoraSaidaConsulta.Text = dgvPesagem.CurrentRow.Cells["dataHoraSaida"].Value.ToString();
            txtClienteConsulta.Text = dgvPesagem.CurrentRow.Cells["Cliente"].Value.ToString();
            txtVeiculoConsulta.Text = dgvPesagem.CurrentRow.Cells["veiculo"].Value.ToString();
            txtMotoristaConsulta.Text = dgvPesagem.CurrentRow.Cells["motorista"].Value.ToString();
            txtMaterialConsulta.Text = dgvPesagem.CurrentRow.Cells["material"].Value.ToString();
            txtPesoEntrada.Text = dgvPesagem.CurrentRow.Cells["pesoEntrada"].Value.ToString();
            txtPesoSaida.Text = dgvPesagem.CurrentRow.Cells["pesoSaida"].Value.ToString();
            lblPesoTotal.Text = dgvPesagem.CurrentRow.Cells["pesoTotal"].Value.ToString();
            txtDataInclusao.Text = dgvPesagem.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtDataAlteracao.Text = dgvPesagem.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text = dgvPesagem.CurrentRow.Cells["usuarioInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text = dgvPesagem.CurrentRow.Cells["usuarioAlteracao"].Value.ToString();
            
            txtStatus.Text = dgvPesagem.CurrentRow.Cells["status"].Value.ToString();
            if (txtStatus.Text.Equals("Em andamento")) {
                txtStatus.ForeColor = System.Drawing.Color.Blue;

            } else if (txtStatus.Text.Equals("Concluída")) {
                txtStatus.ForeColor = System.Drawing.Color.Green;

            } else if (txtStatus.Text.Equals("Cancelada")) {
                txtStatus.ForeColor = System.Drawing.Color.Red;
            }


            txtObservacoes.Text = dgvPesagem.CurrentRow.Cells["observacoes"].Value.ToString();
            txtTipoOperacaoConsulta.Text = dgvPesagem.CurrentRow.Cells["tipoOperacao"].Value.ToString();
        }

        private void btnCancelarPesagem_Click(object sender, EventArgs e)
        {
            if (txtCodigoConsulta.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para realizar o cancelamento da pesagem!");
                return;
            }

                        Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Informe a justificativa para o cancelamento.",
                StartPosition = FormStartPosition.CenterScreen
            };
            
            TextBox txtJustificativa = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmacao = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            Button cancelamento = new Button() { Text = "Cancelar", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(txtJustificativa);
            prompt.Controls.Add(cancelamento);
            prompt.Controls.Add(confirmacao);
            prompt.AcceptButton = confirmacao;
            prompt.CancelButton = cancelamento;

            DialogResult dialogResult = prompt.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                prompt.Close();
                return;
            }
            else {
                if (txtJustificativa.Text.Equals(""))
                {
                    MessageBox.Show("Informe a justificativa");
                    btnCancelarPesagem_Click(sender,e);
                    return;
                }
                
            }
            

            try
            {
                Pesagem objPesagem = new Pesagem();
                PesagemBus p = new PesagemBus();

                objPesagem.codigo = Convert.ToInt16(txtCodigoConsulta.Text);
                objPesagem.status = "Cancelada";

                objPesagem.observacoes = "Motivo Cancelamento:" + txtJustificativa.Text;
                objPesagem.UsuarioAlteracao = Principal.usuario;
                objPesagem.DataAlteracao = DateTime.Now;
                p.alterar(objPesagem);
                
                MessageBox.Show("Pesagem Cancelada com sucesso!");
                this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);

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
    }
}
