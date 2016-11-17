using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Pesagem
    {
        public int codigo { get; set; }
        public Cliente cliente { get; set; }
        public Motorista motorista { get; set; }
        public Veiculo veiculo { get; set; }
        public Material material { get; set; }
        public DateTime dataHoraEntrada { get; set; }
        public DateTime dataHoraSaida { get; set; }
        public Decimal pesoEntrada { get; set; }
        public Decimal pesoSaida { get; set; }
        public Decimal pesoTotal { get; set; }
        public String status { get; set; }
        public String observacoes { get; set; }
        public String tipoOperacao { get; set; }
        public Usuario UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public Pesagem()
        {
            this.UsuarioAlteracao = new Usuario();
            this.UsuarioInclusao = new Usuario();
            this.cliente = new Cliente();
            this.veiculo = new Veiculo();
            this.motorista = new Motorista();
            this.material = new Material();
        }

    }
}
