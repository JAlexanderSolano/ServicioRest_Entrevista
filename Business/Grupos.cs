using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business
{ 
   public class Grupos
    {
        public DataTable ObtenerGrupos()
        {
            Data.Grupos grupos = new Data.Grupos();
            DataTable tblResult = grupos.ObtenerGrupos();
            return tblResult;
        }

        public DataTable RecuperarInformacion(string nombreGrupo)
        {
            Data.Grupos grupos = new Data.Grupos();
            DataTable tblResult = grupos.RecuperarInformacion(nombreGrupo);
            return tblResult;
        }
    }
}
