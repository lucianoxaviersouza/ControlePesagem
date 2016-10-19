using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Veiculo
    {
        public int Codigo { get; set; }
        public String Placa { get; set; }
        public String Cor { get; set; }
        public String Modelo { get; set; }
        public int Ativo { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Veiculo()
        {
            this.Cliente = new Cliente();
            this.UsuarioAlteracao = new Usuario();
            this.UsuarioInclusao = new Usuario();
        }
    }
}
