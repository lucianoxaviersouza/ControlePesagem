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
        public int Cliente { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
