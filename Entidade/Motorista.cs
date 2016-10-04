using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Motorista
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String nomeConhecido { get; set; }
        public String CPF { get; set; }
        public int Ativo { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
