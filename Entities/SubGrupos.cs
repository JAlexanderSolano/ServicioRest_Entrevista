using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SubGrupos
    {
        public string cod_grupo { get; set; }
        public string cod_subgrupo { get; set; }

        public string nom_subgrupo { get; set; }

        public SubGrupos() { }

        public SubGrupos(string cod_grupo, string cod_subgrupo, string nom_subgrupo)
        {
            this.cod_grupo = cod_grupo;
            this.cod_subgrupo = cod_subgrupo;
            this.nom_subgrupo = nom_subgrupo;
        }
    }
}
