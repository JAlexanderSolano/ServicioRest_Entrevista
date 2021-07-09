using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Business
{
    public class SubGrupos
    {
        public DataTable ObtenerSubGrupo()
        {
            Data.SubGrupos subGrupos = new Data.SubGrupos();
            DataTable tblResult = subGrupos.ObtenerSubGrupo();
            return tblResult;
        }
    }
}
