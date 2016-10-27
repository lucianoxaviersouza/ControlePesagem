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
            // TODO: This line of code loads data into the 'controlePesagemDataSet.vw_TipoMaterial_Grid' table. You can move, or remove it, as needed.
            this.vw_TipoMaterial_GridTableAdapter.Fill(this.controlePesagemDataSet.vw_TipoMaterial_Grid);

            dataGridView1.CurrentRow.Cells["column1"].Value = Image.FromFile(@"C:\Users\Luciano\Documents\Visual Studio 2013\Projects\TCCControlePesagem\Apresentacao\icones\arrow_right_green.png");
        }
    }
}
