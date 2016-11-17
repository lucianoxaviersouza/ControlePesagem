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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webRelatorio.Visible = true;
            webRelatorio.Navigate("www.google.com");

        }
    }
}
