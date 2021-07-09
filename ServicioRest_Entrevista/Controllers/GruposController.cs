using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace ServicioRest_Entrevista.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult ObtenerGrupos()
        {
            try
            {

                List<Entities.Grupos> listaGrupos = new List<Entities.Grupos>();
                Business.Grupos grupos = new Business.Grupos();

                DataTable tblResult = grupos.ObtenerGrupos();

                if (tblResult.Rows.Count > 1)
                {
                    string cod_grupo = "", nomb_grupo = "";
                    foreach (DataRow columna in tblResult.Rows)
                    {
                        cod_grupo = columna["cod_grupo"].ToString();
                        nomb_grupo = columna["nom_grupo"].ToString();
                        listaGrupos.Add(new Entities.Grupos(cod_grupo, nomb_grupo) { });
                    }

                }

                return Ok(listaGrupos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
