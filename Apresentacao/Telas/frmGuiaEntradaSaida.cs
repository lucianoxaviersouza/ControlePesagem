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
using System.IO;



namespace Apresentacao.Telas
{
    public partial class frmGuiaEntradaSaida : Form
    {
        private Pesagem ppesagem;
        
        public frmGuiaEntradaSaida()
        {
            InitializeComponent();
        }

        public frmGuiaEntradaSaida(int codigoPesagem)
        {

            PesagemBus p = new PesagemBus();
            ppesagem = p.buscarPorCodigo(codigoPesagem);
            InitializeComponent();
        }

        private void frmGuiaEntradaSaida_Load(object sender, EventArgs e)
        {
            string txtLine;
            txtLine = "";

            StreamReader rd = new StreamReader(@"c:\temp\relatorios\GuiadeEntradaSaida.html");
            StreamWriter wr = new StreamWriter(@"c:\temp\relatorios\GuiadeEntradaSaidaTemp.html");
            
            while (!rd.EndOfStream)
            {

            }
            rd.Close();
            wr.Close();
            wbGuia.Navigate(new Uri("file:///C:/Temp/relatorios/GuiadeEntradaSaidaTemp.html"));
        }
    }
}
