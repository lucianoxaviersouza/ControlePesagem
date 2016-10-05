using Apresentacao.Util;
using Apresentacao.Telas;
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
    public partial class frmMaterial : Form
    {

        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao
        {
            inclusao, alteracao, delecao
        };

        public frmMaterial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            this.vw_Material_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Material_Grid);
            dgvMaterial.Sort(dgvMaterial.Columns[0], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvMaterial.RowCount);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            Material objMaterial = new Material();
            MaterialBus material = new MaterialBus();
            
            objMaterial.Descricao = txtDescricao.Text;
            objMaterial.Ativo = Convert.ToInt16(chkAtivo.Checked);
            objMaterial.TipoMaterial.Codigo = Convert.ToInt16(cboTipoMaterial.SelectedValue.ToString());

            
            if (globalTipoAcao.Equals(enunTipoAcao.inclusao))
            {
                objMaterial.UsuarioInclusao = Principal.usuario;
                objMaterial.DataInclusao = DateTime.Now;
                material.inserir(objMaterial);
                MessageBox.Show("Registro Inserido com sucesso!");
            }
            else if (globalTipoAcao.Equals(enunTipoAcao.alteracao))
            {

                objMaterial.Codigo = Convert.ToInt16(txtCodigo.Text);
                objMaterial.UsuarioAlteracao = Principal.usuario;
                objMaterial.DataAlteracao = DateTime.Now;
                material.alterar(objMaterial);
                MessageBox.Show("Registro Alterado com sucesso!");
            }


            this.vw_Material_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Material_Grid);
            dgvMaterial.Refresh();
            dgvMaterial.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvMaterial.RowCount);

            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            ControleTela.LimpaCampos(this);
            txtDescricao.Enabled = false;
            chkAtivo.Enabled = false;
            cboTipoMaterial.Text = "";
            cboTipoMaterial.Enabled = false;
            dgvMaterial.Enabled = true;
        }

        private void stbtIncluir_Click(object sender, EventArgs e)
        {
            dgvMaterial.Enabled = false;
            globalTipoAcao = enunTipoAcao.inclusao;
            stAcoes.Enabled = false;
            txtDescricao.Enabled = true;
            cboTipoMaterial.Enabled = true;
            cboTipoMaterial.Focus();
            chkAtivo.Enabled = true;
            ControleTela.LimpaCampos(this);
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);

        }

        private void stbtAlterar_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.alteracao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para alteração!");
            }

            /* Manipula controles em tela */
            dgvMaterial.Enabled = false;
            stAcoes.Enabled = false;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            cboTipoMaterial.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            ControleTela.LimpaCampos(this);
            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            dgvMaterial.Enabled = true;
            cboTipoMaterial.Text="" ;
            cboTipoMaterial.Enabled = false;


        }

        private void stbtExcluir_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.delecao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para deleção!");

            }
            else
            {

                Material objMaterial = new Material();
                MaterialBus material = new MaterialBus();

                objMaterial.Codigo = Convert.ToInt16(txtCodigo.Text);

                material.excluir(objMaterial);
                MessageBox.Show("Registro Excluído com sucesso!");
                ControleTela.LimpaCampos(this);
                this.vw_Material_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Material_Grid);
                dgvMaterial.Refresh();
                dgvMaterial.Update();
                gboxDados.Text = String.Concat("Registros: ", dgvMaterial.RowCount);
            }
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescricao.Text = dgvMaterial.CurrentRow.Cells["descricao"].Value.ToString();
            txtCodigo.Text = dgvMaterial.CurrentRow.Cells["codigo"].Value.ToString();
            txtDataAlteracao.Text = dgvMaterial.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtDataInclusao.Text = dgvMaterial.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text = dgvMaterial.CurrentRow.Cells["UsuarioAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text = dgvMaterial.CurrentRow.Cells["dataInclusao"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvMaterial.CurrentRow.Cells["ativo"].Value.ToString()));
            cboTipoMaterial.Text = dgvMaterial.CurrentRow.Cells["descricaoTipoMaterial"].Value.ToString();
            
        }
    }
}
