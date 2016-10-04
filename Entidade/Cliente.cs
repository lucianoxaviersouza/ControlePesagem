using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public String RazaoSocial { get; set; }
        public String NomeFantasia { get; set; }
        public String CNPJ { get; set; }
        public String Telefone1 { get; set; }
        public String Telefone2 { get; set; }
        public int Ativo { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }


        public DateTime DataAlteracao { get; set; }
    }
}
