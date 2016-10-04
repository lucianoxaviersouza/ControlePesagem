using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Material
    {
        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public TipoMaterial TipoMaterial { get; set; }
        public int Ativo { get; set; }
        public int UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        //TESTE COMMIT
        public Material() {
            this.TipoMaterial = new TipoMaterial();

        }
    }
}
