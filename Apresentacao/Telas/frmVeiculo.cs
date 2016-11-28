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
    public partial class frmVeiculo : Form
    {

        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao
        {
            inclusao, alteracao, delecao
        };
        
        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_Cliente_Grid' table. You can move, or remove it, as needed.
            this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
            
            cboCliente.Text = "";
            cboClienteBusca.Text = "";
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_Veiculo_Grid' table. You can move, or remove it, as needed.
            this.vw_Veiculo_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Veiculo_Grid);


            
           dgvVeiculo.Sort(dgvVeiculo.Columns[0], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvVeiculo.RowCount);

        }

        private void stbtIncluir_Click(object sender, EventArgs e)
        {

            dgvVeiculo.Enabled = false;
            globalTipoAcao = enunTipoAcao.inclusao;
            stAcoes.Enabled = false;
            txtModelo.Enabled = true;
            txtCor.Enabled = true;
            txtPlaca.Enabled = true;
            
            
            cboCliente.Enabled = true;
            cboCliente.Focus();
            chkAtivo.Enabled = true;

            ControleTela.LimpaCampos(this);
            chkAtivo.Checked = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnBuscarTodos.Enabled = false;
            btnBuscar.Enabled = false;
            txtPlacaBusca.Enabled = false;
            cboClienteBusca.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControleTela.LimpaCampos(this);

            //Controles de ação
            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            //Controles de Exibição
           dgvVeiculo.Enabled = true;

            //Controles de Input
            txtModelo.Enabled = false;
            txtCor.Enabled = false;
            txtPlaca.Enabled = false;
            cboCliente.Enabled = false;
            chkAtivo.Enabled = false;

            //Controles de Busca
            btnBuscarTodos.Enabled = true;
            btnBuscar.Enabled = true;
            txtPlacaBusca.Enabled = true;
            cboClienteBusca.Enabled = true;


            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try{
            Veiculo objVeiculo = new Veiculo();
            VeiculoBus veiculo = new VeiculoBus();

            objVeiculo.Cliente.Codigo = Convert.ToInt16(cboCliente.SelectedValue.ToString());
            objVeiculo.Modelo = txtModelo.Text;
            objVeiculo.Placa = txtPlaca.Text;
            objVeiculo.Cor = txtCor.Text;
            objVeiculo.Ativo = Convert.ToInt16(chkAtivo.Checked);

            if (globalTipoAcao.Equals(enunTipoAcao.inclusao))
            {
                objVeiculo.UsuarioInclusao = Principal.usuario;
                objVeiculo.DataInclusao = DateTime.Now;
                veiculo.inserir(objVeiculo);
                MessageBox.Show("Registro Inserido com sucesso!");
            }
            else if (globalTipoAcao.Equals(enunTipoAcao.alteracao))
            {

                objVeiculo.Codigo = Convert.ToInt16(txtCodigo.Text);
                objVeiculo.UsuarioAlteracao = Principal.usuario;
                objVeiculo.DataAlteracao = DateTime.Now;
                veiculo.alterar(objVeiculo);
                MessageBox.Show("Registro Alterado com sucesso!");
            }
            
            ControleTela.LimpaCampos(this);

            //Controles de Exibição
           dgvVeiculo.Enabled = true;
            this.vw_Veiculo_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Veiculo_Grid);
           dgvVeiculo.Refresh();
           dgvVeiculo.Update();
            gboxDados.Text = String.Concat("Registros: ",dgvVeiculo.RowCount);
                
            //Controles de ação
            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            //Controles de Input
            txtModelo.Enabled = false;
            txtCor.Enabled = false;
            txtPlaca.Enabled = false;
            cboCliente.Enabled = false;
            chkAtivo.Enabled = false;

            //Controles de Busca
            btnBuscarTodos.Enabled = true;
            btnBuscar.Enabled = true;
            txtPlacaBusca.Enabled = true;
            cboClienteBusca.Enabled = true;

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

        private void stbtAlterar_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.alteracao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para alteração!");
                return;
            }
            

            //Controles de Exibição
           dgvVeiculo.Enabled = false;
            

            //Controles de ação
            stAcoes.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            //Controles de Input
            txtModelo.Enabled = true;
            txtCor.Enabled = true;
            txtPlaca.Enabled = true;
            cboCliente.Enabled = true;
            chkAtivo.Enabled = true;

            //Controles de Busca
            btnBuscarTodos.Enabled = false;
            btnBuscar.Enabled = false;
            txtPlacaBusca.Enabled = false;
            cboClienteBusca.Enabled = false;

            
        }

        private void dgvVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            txtCodigo.Text =dgvVeiculo.CurrentRow.Cells["codigo"].Value.ToString();
            txtModelo.Text =dgvVeiculo.CurrentRow.Cells["modelo"].Value.ToString();
            txtCor.Text =dgvVeiculo.CurrentRow.Cells["cor"].Value.ToString();
            txtPlaca.Text =dgvVeiculo.CurrentRow.Cells["placa"].Value.ToString();
            cboCliente.Text =dgvVeiculo.CurrentRow.Cells["NomeFantasiaCliente"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvVeiculo.CurrentRow.Cells["ativo"].Value.ToString()));
            txtDataAlteracao.Text =dgvVeiculo.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtDataInclusao.Text =dgvVeiculo.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text =dgvVeiculo.CurrentRow.Cells["UsuarioAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text =dgvVeiculo.CurrentRow.Cells["dataInclusao"].Value.ToString();
            
        }

        private void stbtExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                globalTipoAcao = enunTipoAcao.delecao;
                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Selecione um registro para deleção!");
                    return;

                }
                
            Veiculo objVeiculo = new Veiculo();
            VeiculoBus veiculo = new VeiculoBus();

            objVeiculo.Codigo = Convert.ToInt16(txtCodigo.Text);

            veiculo.excluir(objVeiculo);
            MessageBox.Show("Registro Excluído com sucesso!");
            ControleTela.LimpaCampos(this);
            this.vw_Veiculo_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Veiculo_Grid);
           dgvVeiculo.Refresh();
           dgvVeiculo.Update();
            gboxDados.Text = String.Concat("Registros: ",dgvVeiculo.RowCount);
                
            }
            catch (Exception ex)
            {

                if (ex is System.Data.SqlClient.SqlException)
                {
                    System.Data.SqlClient.SqlException erro = (System.Data.SqlClient.SqlException)ex;
                    if (erro.Number == 547)
                    {
                        MessageBox.Show("Exclusão não permitida. Registro em uso em outros cadastros. ", "Ação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro inesperado ao realizar a exclusão. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboClienteBusca.Text != "")
            {
                
                vw_Veiculo_GridTableAdapter.FillByNomeFantasiaClienteVeic(controlePesagemDataSet.vw_Veiculo_Grid, cboClienteBusca.Text);
            }
            else if (txtPlacaBusca.Text != "")
            {
                
                vw_Veiculo_GridTableAdapter.FillByPlacaVeiculo(controlePesagemDataSet.vw_Veiculo_Grid, txtPlacaBusca.Text);
            }
            dgvVeiculo.Refresh();
            dgvVeiculo.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvVeiculo.RowCount);
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            txtPlacaBusca.Text = "";
            vw_Veiculo_GridTableAdapter.Fill(controlePesagemDataSet.vw_Veiculo_Grid);
            dgvVeiculo.Refresh();
            dgvVeiculo.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvVeiculo.RowCount);
        }
    }
}
