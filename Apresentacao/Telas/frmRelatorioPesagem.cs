using Microsoft.Reporting.WinForms;
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
    public partial class frmRelatorioPesagem : Form
    {
        public frmRelatorioPesagem()
        {
            InitializeComponent();
        }

        private void frmRelatorioPesagem_Load(object sender, EventArgs e)
        {

            this.vw_Material_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_Material_Grid);
            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);
            this.reportViewer1.RefreshReport();
            cboMaterial.Text = "";
            dtpDataPesagem.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBusca.Text != "")
            {
                vw_PesagemConsulta_GridTableAdapter.FillByCodigo(controlePesagemDataSet.vw_PesagemConsulta_Grid,Convert.ToInt16(txtCodigoBusca.Text));
             

            }
            else if (!dtpDataPesagem.Text.Equals("  /  /"))
            {
                vw_PesagemConsulta_GridTableAdapter.FillByDataPesagem(controlePesagemDataSet.vw_PesagemConsulta_Grid, Convert.ToDateTime(dtpDataPesagem.Text));
            }

            else if (txtCliente.Text != "")
            {
                vw_PesagemConsulta_GridTableAdapter.FillByClientePesagem(controlePesagemDataSet.vw_PesagemConsulta_Grid, txtCodigoBusca.Text);
            }
            else if (txtMotorista.Text != "")
            {
                vw_PesagemConsulta_GridTableAdapter.FillByMotoristaPesagem(controlePesagemDataSet.vw_PesagemConsulta_Grid, txtMotorista.Text);
            }

            else if (cboMaterial.Text != "")
            {
                vw_PesagemConsulta_GridTableAdapter.FillByMaterialPesagem(controlePesagemDataSet.vw_PesagemConsulta_Grid, cboMaterial.Text);
            }

            reportViewer1.RefreshReport();

        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);
            reportViewer1.RefreshReport();
        }
    }
}
