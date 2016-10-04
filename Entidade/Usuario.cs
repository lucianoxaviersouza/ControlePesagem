using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public String Nome { get; set; }
        public int Ativo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
