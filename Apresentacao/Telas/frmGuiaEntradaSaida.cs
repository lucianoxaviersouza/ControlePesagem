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
            string txt;
            txt = "";
            
            StreamReader rd = new StreamReader(@"c:\temp\relatorios\GuiadeEntradaSaida.html",false);
            StreamWriter wr = new StreamWriter(@"c:\temp\relatorios\GuiadeEntradaSaidaTemp.html",false, Encoding.UTF8);
            
            while (!rd.EndOfStream)
            {
                txt = "";
                txt = rd.ReadLine();
                txt = txt.Replace("@cliente", ppesagem.cliente.NomeFantasia);
                txt = txt.Replace("@placa", ppesagem.veiculo.Placa);
                txt = txt.Replace("@motorista", ppesagem.motorista.nomeConhecido);
                txt = txt.Replace("@operacao", ppesagem.tipoOperacao);
                txt = txt.Replace("@material", ppesagem.material.Descricao);
                txt = txt.Replace("@codigo", ppesagem.codigo.ToString());
                txt = txt.Replace("@dtEntrada", ppesagem.dataHoraEntrada.ToString());
                txt = txt.Replace("@pesoEntrada", ppesagem.pesoEntrada.ToString());
                txt = txt.Replace("@dtSaida", ppesagem.dataHoraSaida.ToString());
                txt = txt.Replace("@pesoSaida", ppesagem.pesoSaida.ToString());
                txt = txt.Replace("@pesoTotal", ppesagem.pesoTotal.ToString());
                txt = txt.Replace("@status", ppesagem.status);
                wr.WriteLine(txt);

            }
            rd.Close();
            wr.Close();
            wbGuia.Navigate(new Uri("file:///C:/Temp/relatorios/GuiadeEntradaSaidaTemp.html"));
        }
    }
}
