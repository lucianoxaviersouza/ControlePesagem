﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao.Util;
using Entidade;
using Negocio;
using Apresentacao;

namespace Apresentacao.Telas
{
    public partial class frmCliente : Form
    {


        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao
        {
            inclusao, alteracao, delecao
        };

        public frmCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControleTela.LimpaCampos(this);


            txtCNPJ.Enabled = false;
            txtTelefone1.Enabled = false;
            txtTelefone2.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtEmail.Enabled = false;
            chkAtivo.Enabled = false;

            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            dgvCliente.Enabled = true;

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

            this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
            dgvCliente.Sort(dgvCliente.Columns[0], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvCliente.RowCount);

        }

        private void stbtIncluir_Click(object sender, EventArgs e)
        {
            dgvCliente.Enabled = false;
            globalTipoAcao = enunTipoAcao.inclusao;
            stAcoes.Enabled = false;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtEmail.Enabled = true;
            txtCNPJ.Enabled = true;
            txtTelefone1.Enabled = true;
            txtTelefone2.Enabled = true;
            chkAtivo.Enabled = true;
            ControleTela.LimpaCampos(this);


            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try{
                Cliente objCliente = new Cliente();
                ClienteBus cliente = new ClienteBus();

                objCliente.NomeFantasia = txtNomeFantasia.Text;
                objCliente.RazaoSocial = txtRazaoSocial.Text;
                objCliente.Telefone1 = txtTelefone1.Text;
                objCliente.Telefone2 = txtTelefone2.Text;
                objCliente.email = txtEmail.Text;
                objCliente.Ativo = Convert.ToInt16(chkAtivo.Checked);
                objCliente.CNPJ = txtCNPJ.Text;



                if (globalTipoAcao.Equals(enunTipoAcao.inclusao))
                {
                    objCliente.UsuarioInclusao = Principal.usuario;
                    objCliente.DataInclusao = DateTime.Now;
                    cliente.inserir(objCliente);
                    MessageBox.Show("Registro Inserido com sucesso!");
                }
                else if (globalTipoAcao.Equals(enunTipoAcao.alteracao))
                {

                    objCliente.Codigo = Convert.ToInt16(txtCodigo.Text);
                    objCliente.UsuarioAlteracao = Principal.usuario;
                    objCliente.DataAlteracao = DateTime.Now;
                    cliente.alterar(objCliente);
                    MessageBox.Show("Registro Alterado com sucesso!");
                }


                this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
                dgvCliente.Refresh();
                dgvCliente.Update();
                gboxDados.Text = String.Concat("Registros: ", dgvCliente.RowCount);

                stAcoes.Enabled = true;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                ControleTela.LimpaCampos(this);
                txtCNPJ.Enabled = false;
                txtTelefone1.Enabled = false;
                txtTelefone2.Enabled = false;
                txtRazaoSocial.Enabled = false;
                txtNomeFantasia.Enabled = false;
                txtEmail.Enabled = false;
                chkAtivo.Enabled = false;
                dgvCliente.Enabled = true;
            
        }catch (Exception ex)
            {

                if (ex is System.Data.SqlClient.SqlException)
                {
                    System.Data.SqlClient.SqlException erro = (System.Data.SqlClient.SqlException)ex;

                    MessageBox.Show("Erro inesperado ao realizar a inclusão no banco de dados. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(), "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else {
                    MessageBox.Show("Erro inesperado ao realizar a exclusão. \n Informe o erro abaixo ao administrador do sistema. \n Erro: " + ex.Message.ToString(),"Erro inesperado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodigo.Text = dgvCliente.CurrentRow.Cells["codigo"].Value.ToString();
            txtRazaoSocial.Text = dgvCliente.CurrentRow.Cells["razaoSocial"].Value.ToString();
            txtNomeFantasia.Text = dgvCliente.CurrentRow.Cells["nomeFantasia"].Value.ToString();
            txtCNPJ.Text = dgvCliente.CurrentRow.Cells["cnpj"].Value.ToString();
            txtTelefone1.Text = dgvCliente.CurrentRow.Cells["telefone1"].Value.ToString();
            txtTelefone2.Text = dgvCliente.CurrentRow.Cells["telefone2"].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells["email"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvCliente.CurrentRow.Cells["ativo"].Value.ToString()));
            txtDataAlteracao.Text = dgvCliente.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtDataInclusao.Text = dgvCliente.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text = dgvCliente.CurrentRow.Cells["UsuarioAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text = dgvCliente.CurrentRow.Cells["dataInclusao"].Value.ToString();
            
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
                else
                {

                    Cliente objCliente = new Cliente();
                    ClienteBus cliente = new ClienteBus();

                    objCliente.Codigo = Convert.ToInt16(txtCodigo.Text);

                    cliente.excluir(objCliente);

                    MessageBox.Show("Registro Excluído com sucesso!");
                    ControleTela.LimpaCampos(this);


                    this.vw_Cliente_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Cliente_Grid);
                    dgvCliente.Refresh();
                    dgvCliente.Update();
                    gboxDados.Text = String.Concat("Registros: ", dgvCliente.RowCount);


                }
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

        private void stbtAlterar_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.alteracao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para alteração!");
            }
            else
            {
                /* Manipula controles em tela */
                dgvCliente.Enabled = false;
                stAcoes.Enabled = false;
                txtRazaoSocial.Enabled = true;
                txtNomeFantasia.Enabled = true;
                txtEmail.Enabled = true;
                txtCNPJ.Enabled = true;
                txtTelefone1.Enabled = true;
                txtTelefone2.Enabled = true;
                chkAtivo.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                
            }
        }
        }
    }
