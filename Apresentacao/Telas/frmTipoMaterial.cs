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
    public partial class frmTipoMaterial : Form
    {

        internal enunTipoAcao globalTipoAcao;
        internal enum enunTipoAcao { 
             inclusao,alteracao,delecao
        };

        public frmTipoMaterial()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            TipoMaterial objTipoMaterial = new TipoMaterial();
            TipoMaterialBus tpMaterial = new TipoMaterialBus();
            objTipoMaterial.Descricao = txtDescricao.Text;
            objTipoMaterial.Ativo = Convert.ToInt16 (chkAtivo.Checked);
            
            
            

            if (globalTipoAcao.Equals(enunTipoAcao.inclusao))
            {
                objTipoMaterial.UsuarioInclusao = Principal.usuario;
                objTipoMaterial.DataInclusao = DateTime.Now;
                tpMaterial.inserir(objTipoMaterial);
                MessageBox.Show("Registro Inserido com sucesso!");
            }
            else if (globalTipoAcao.Equals(enunTipoAcao.alteracao))
            {
                
                objTipoMaterial.Codigo = Convert.ToInt16(txtCodigo.Text);
                objTipoMaterial.UsuarioAlteracao = Principal.usuario;
                objTipoMaterial.DataAlteracao = DateTime.Now;
                tpMaterial.alterar(objTipoMaterial);
                MessageBox.Show("Registro Alterado com sucesso!");
            }


            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);
            dgvTipoMaterial.Refresh();
            dgvTipoMaterial.Update();
            gboxDados.Text = String.Concat( "Registros: ", dgvTipoMaterial.RowCount);

            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            ControleTela.LimpaCampos(this);
            txtDescricao.Enabled = false;
            chkAtivo.Enabled = false;
            dgvTipoMaterial.Enabled = true;

            
        }

        private void frmTipoMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_TipoMaterial_Grid' table. You can move, or remove it, as needed.
            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);
            dgvTipoMaterial.Sort(dgvTipoMaterial.Columns[0], ListSortDirection.Descending);
            gboxDados.Text = String.Concat("Registros: ", this.dgvTipoMaterial.RowCount);

        }

     

        private void stbtIncluir_Click(object sender, EventArgs e)
        {
            
            dgvTipoMaterial.Enabled = false;
            globalTipoAcao = enunTipoAcao.inclusao;
            stAcoes.Enabled = false;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            chkAtivo.Enabled = true;
            ControleTela.LimpaCampos(this);
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            

        }

        private void stbtAlterar_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.alteracao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para alteração!");
            }
            
            /* Manipula controles em tela */
            dgvTipoMaterial.Enabled = false;
            stAcoes.Enabled = false;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControleTela.LimpaCampos(this);
            stAcoes.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            dgvTipoMaterial.Enabled = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void dgvTipoMaterial_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtDescricao.Text = dgvTipoMaterial.CurrentRow.Cells["descricao"].Value.ToString();
            txtCodigo.Text = dgvTipoMaterial.CurrentRow.Cells["codigo"].Value.ToString();
            txtDataAlteracao.Text = dgvTipoMaterial.CurrentRow.Cells["dataAlteracao"].Value.ToString();
            txtDataInclusao.Text = dgvTipoMaterial.CurrentRow.Cells["dataInclusao"].Value.ToString();
            txtUsuarioAlteracao.Text = dgvTipoMaterial.CurrentRow.Cells["UsuarioAlteracao"].Value.ToString();
            txtUsuarioInclusao.Text = dgvTipoMaterial.CurrentRow.Cells["dataInclusao"].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(Convert.ToInt16(dgvTipoMaterial.CurrentRow.Cells["ativo"].Value.ToString()));
            
        }


        private void stbtExcluir_Click(object sender, EventArgs e)
        {
            globalTipoAcao = enunTipoAcao.alteracao;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Selecione um registro para alteração!");
            }

            TipoMaterial objTipoMaterial = new TipoMaterial();
            TipoMaterialBus tpMaterial = new TipoMaterialBus();
            
            objTipoMaterial.Codigo = Convert.ToInt16(txtCodigo.Text);
            
            tpMaterial.excluir(objTipoMaterial);
            MessageBox.Show("Registro Excluído com sucesso!");
            ControleTela.LimpaCampos(this);
            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);
            dgvTipoMaterial.Refresh();
            dgvTipoMaterial.Update();
            gboxDados.Text = String.Concat("Registros: ", dgvTipoMaterial.RowCount);

            }
     }
}
