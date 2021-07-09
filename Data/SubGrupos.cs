using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SubGrupos
    {
        public DataTable ObtenerSubGrupo()
        {
            string Query = String.Format("select * from inv_subgrupos");
            DataTable tblResut = Conexion.Consultar(Query);
            return tblResut;
        }
    }
}
