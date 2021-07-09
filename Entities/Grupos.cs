using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Grupos
    {
        public string cod_grupo { get; set; }

        public string nomb_grupo { get; set; }


        public Grupos() { }

        public Grupos(string cod_grupo, string nomb_grupo)
        {
            this.cod_grupo = cod_grupo;
            this.nomb_grupo = nomb_grupo;
        }
    }
}
