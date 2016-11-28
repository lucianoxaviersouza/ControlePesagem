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
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_PesagemConsulta_Grid' table. You can move, or remove it, as needed.
            this.vw_PesagemConsulta_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_PesagemConsulta_Grid);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBusca.Text != "")
            {
                vw_PesagemConsulta_GridTableAdapter.FillByCodigo(controlePesagemDataSet.vw_PesagemConsulta_Grid,Convert.ToInt32(txtCodigoBusca.Text));
                reportViewer1.RefreshReport();

            }
        }
    }
}
