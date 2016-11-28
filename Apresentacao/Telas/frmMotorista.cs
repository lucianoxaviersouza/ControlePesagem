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
    public partial class frmMotorista : Form
    {

        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao
        {
            inclusao, alteracao, delecao
        };
        
        public frmMotorista()
        {
            InitializeComponent();
        }

        private void frmMotorista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_Cliente_Grid' table. You can move, or remove it, as needed.
            this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_Cliente_Grid' table. You can move, or remove it, as needed.
            cboCliente.Text = "";
            cboClienteBusca.Text = "";
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_Motorista_Grid' table. You can move, or remove it, as needed.
            this.vw_Motorista_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Motorista_Grid);


            
            dgvMotorista.Sort(dgvMotorista.Columns[0], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvMotorista.RowCount);

        }

        private void stbtIncluir_Click(object sender, EventArgs e)
        {

            dgvMotorista.Enabled = false;
            globalTipoAcao = enunTipoAcao.inclusao;
            stAcoes.Enabled = false;
            txtNome.Enabled = true;
            txtNomeConhecido.Enabled = true;
            txtSobreNome.Enabled = true;
            txtCPF.Enabled = true;
            
            cboCliente.Enabled = true;
            cboCliente.Focus();
            chkAtivo.Enabled = true;

            ControleTela.LimpaCampos(this);
            chkAtivo.Checked = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnBuscarTodos.Enabled = false;
            btnBuscar.Enabled = false;
            txtNomeBusca.Enabled = false;
            txtNomeConhecidoBusca.Enabled = false;
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
            dgvMotorista.Enabled = true;

            //Controles de Input
            txtNome.Enabled = false;
            txtNomeConhecido.Enabled = false;
            txtSobreNome.Enabled = false;
            txtCPF.Enabled = false;
            cboCliente.Enabled = false;
            chkAtivo.Enabled = false;

            //Controles de Busca
            btnBuscarTodos.Enabled = true;
            btnBuscar.Enabled = true;
            txtNomeBusca.Enabled = true;
            txtNomeConhecidoBusca.Enabled = true;
            cboClienteBusca.Enabled = true;


            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try{
            Motorista objMotorista = new Motorista();
            MotoristaBus motorista = new MotoristaBus();

            objMotorista.Cliente.Codigo = Convert.ToInt16(cboCliente.SelectedValue.ToString());
            objMotorista.Nome = txtNome.Text;
            objMotorista.Sobrenome = txtSobreNome.Text;
            objMotorista.nomeConhecido = txtNomeConhecido.Text;
            objMotorista.CPF  = txtCPF.Text;
            objMotorista.Ativo = Convert.ToInt16(chkAtivo.Checked);

            if (globalTipoAcao.Equals(enunTipoAcao.inclusao))
            {
                objMotorista.UsuarioInclusao = Principal.usuario;
                objMotorista.DataInclusao = DateTime.Now;
                motorista.inserir(objMotorista);
                MessageBox.Show("Registro Inserido com sucesso!");
            }
            else if (globalTipoAcao.Equals(enunTipoAcao.alteracao))
            {

                objMotorista.Codigo = Convert.ToInt16(txtCodigo.Text);
                objMotorista.UsuarioAlteracao = Principal.usuario;
                objMotorista.DataAlteracao = DateTime.Now;
                motorista.alterar(objMotorista);
                MessageBox.Show("Registro Alterado com sucesso!");
            }
            
            ControleTela.LimpaCampos(this);

            //Controles de Exibição
            dgvMotorista.Enabled = true;
            this.vw_Motorista_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Motorista_Grid);
            dgvMotorista.Refresh();
            dgvMotorista.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvMotorista.RowCount);
                
            //Controles de ação
            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            //Controles de Input
            txtNome.Enabled = false;
            txtNomeConhecido.Enabled = false;
            txtSobreNome.Enabled = false;
            txtCPF.Enabled = false;
            cboCliente.Enabled = false;
            chkAtivo.Enabled = false;

            //Controles de Busca
            btnBuscarTodos.Enabled = true;
            btnBuscar.Enabled = true;
            txtNomeBusca.Enabled = true;
            txtNomeConhecidoBusca.Enabled = true;
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
                    MessageBox.Show("Erro inesperado ao realizar a exclusão. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvMotorista.Enabled = false;
            

            //Controles de ação
            stAcoes.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            //Controles de Input
            txtNome.Enabled = true;
            txtNomeConhecido.Enabled = true;
            txtSobreNome.Enabled = true;
            txtCPF.Enabled = true;
            cboCliente.Enabled = true;
            chkAtivo.Enabled = true;

            //Controles de Busca
            btnBuscarTodos.Enabled = false;
            btnBuscar.Enabled = false;
            txtNomeBusca.Enabled = false;
            txtNomeConhecidoBusca.Enabled = false;
            cboClienteBusca.Enabled = false;

            
        }

        private void dgvMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            txtCodigo.Text = dgvMotorista.CurrentRow.Cells["codigo"].Value.ToString();
            txtNome.Text = dgvMotorista.CurrentRow.Cells["nome"].Value.ToString();
            txtNomeConhecido.Text = dgvMotorista.CurrentRow.Cells["nomeConhecido"].Value.ToString();
            txtSobreNome.Text = dgvMotorista.CurrentRow.Cells["sobrenome"].Value.ToString();
            txtCPF.Text = dgvMotorista.CurrentRow.Cells["cpf"].Value.ToString();
            cboCliente.Text = dgvMotorista.CurrentRow.Cells["NomeFantasiaCliente"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvMotorista.CurrentRow.Cells["ativo"].Value.ToString()));
            txtDataAlteracao.Text = dgvMotorista.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtDataInclusao.Text = dgvMotorista.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text = dgvMotorista.CurrentRow.Cells["UsuarioAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text = dgvMotorista.CurrentRow.Cells["dataInclusao"].Value.ToString();

            
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
                
            Motorista objMotorista = new Motorista();
            MotoristaBus motorista = new MotoristaBus();

            objMotorista.Codigo = Convert.ToInt16(txtCodigo.Text);

            motorista.excluir(objMotorista);
            MessageBox.Show("Registro Excluído com sucesso!");
            ControleTela.LimpaCampos(this);
            this.vw_Motorista_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Motorista_Grid);
            dgvMotorista.Refresh();
            dgvMotorista.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvMotorista.RowCount);
                
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
                //TODO Fix
                //vw_Motorista_GridTableAdapter.FillByNomeFantasiaCliente(controlePesagemDataSet.vw_Motorista_Grid, cboClienteBusca.Text);
            }
            else if (txtNomeBusca.Text != "")
            {
                //TODO Fix
                //vw_Motorista_GridTableAdapter.FillByNome(controlePesagemDataSet.vw_Motorista_Grid, txtNomeBusca.Text);

            }
            else if (txtNomeConhecidoBusca.Text != "")
            {
                //TODO Fix
                //vw_Motorista_GridTableAdapter.FillByNomeConhecido(controlePesagemDataSet.vw_Motorista_Grid, txtNomeConhecidoBusca.Text);

            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            txtNomeConhecidoBusca.Text = "";
            txtNomeBusca.Text = "";
            vw_Motorista_GridTableAdapter.Fill(controlePesagemDataSet.vw_Motorista_Grid);
        }
    }
}
