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
            txtObservacoes.Text = dgvPesagem.CurrentRow.Cells["observacoes"].Value.ToString();
            txtTipoOperacaoConsulta.Text = dgvPesagem.CurrentRow.Cells["tipoOperacao"].Value.ToString();
        }
    }
}
