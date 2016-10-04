using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class TipoMaterial
    {
        
        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public int Ativo { get; set; }
        public Usuario UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public TipoMaterial()
        {
            this.UsuarioAlteracao = new Usuario();
            this.UsuarioInclusao = new Usuario();

        }    
    }

     


    }
