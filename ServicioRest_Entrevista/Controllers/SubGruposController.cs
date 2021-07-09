using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioRest_Entrevista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubGruposController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult ObtenerSubCategorias()
        {
            try
            {
                List<Entities.SubGrupos> listsubGrupos = new List<Entities.SubGrupos>();

                Business.SubGrupos subGrupos = new Business.SubGrupos();

                DataTable tblResult = subGrupos.ObtenerSubGrupo();

                if (tblResult.Rows.Count > 0)
                {
                    string cod_grupo = "", cod_subgrupo = "", nom_subgrupo = "";

                    foreach (DataRow fila in tblResult.Rows)
                    {

                        cod_grupo = fila["cod_grupo"].ToString();
                        cod_subgrupo = fila["cod_subgrupo"].ToString();
                        nom_subgrupo = fila["nom_subgrupo"].ToString();

                        listsubGrupos.Add(new Entities.SubGrupos(cod_grupo, cod_subgrupo, nom_subgrupo) { });
                    }
                }

                return Ok(listsubGrupos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
