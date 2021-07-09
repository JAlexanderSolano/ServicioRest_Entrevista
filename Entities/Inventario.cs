using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Inventario
    {
        public string cod_alterno { get; set; }
        public string des_item { get; set; }
        public string cod_grupo { get; set; }
        public string cod_subgrupo { get; set; }
        public string pre_vt1 { get; set; }
        public string cod_grupo2 { get; set; }
        public string nom_grupo { get; set; }
        public string cod_grupo3 { get; set; }
        public string cod_subgrupo2 { get; set; }
        public string nom_subgrupo { get; set; }
        public Inventario() { }

        public Inventario(string cod_alterno, string des_item, string cod_grupo, string cod_subgrupo, string pre_vt1, string cod_grupo2, string nom_grupo, string cod_grupo3, string cod_subgrupo2, string nom_subgrupo)
        {
            this.cod_alterno = cod_alterno;
            this.des_item = des_item;
            this.cod_grupo = cod_grupo;
            this.cod_subgrupo = cod_subgrupo;
            this.pre_vt1 = pre_vt1;
            this.cod_grupo2 = cod_grupo2;
            this.nom_grupo = nom_grupo;
            this.cod_grupo3 = cod_grupo3;
            this.cod_subgrupo2 = cod_subgrupo2;
            this.nom_subgrupo = nom_subgrupo;


        }


    }
}
