using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Grupos
    {
        public DataTable ObtenerGrupos()
        {
            string Query = String.Format("select * from inv_grupos");
            DataTable Result = Conexion.Consultar(Query);
            return Result;
        }

        public DataTable RecuperarInformacion(string nombreGrupo)
        {
            string Query = String.Format("exec sp_ObtenerInformacionInventario '{0}'", nombreGrupo);
            DataTable Result = Conexion.Consultar(Query);
            return Result;
        }
    }
}
