using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using ServicioRest_Entrevista.InputModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioRest_Entrevista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecuperarInformacionController : ControllerBase
    {
        [HttpPost("[action]")]
        public IActionResult RecuperarInformacion([FromBody] ItemNombreGrupo itemNombreGrupo)
        {
            string nombreGrupo = itemNombreGrupo.NombreGrupo;
            try
            {
                if (nombreGrupo == "")
                {
                    return BadRequest("Ingrese un grupo correcto");
                }
                else
                {
                    Business.Grupos grupos = new Business.Grupos();
                    DataTable tblResult = grupos.RecuperarInformacion(nombreGrupo);

                    List<Entities.Inventario> listaInventario = new List<Entities.Inventario>();
                    if (tblResult.Rows.Count > 0)
                    {
                        string cod_alterno,  des_item,  cod_grupo,cod_subgrupo,
                               pre_vt1,      cod_grupo2,nom_grupo,cod_grupo3,
                               cod_subgrupo2,nom_subgrupo;
                        foreach (DataRow fila in tblResult.Rows)
                        {
                            cod_alterno = fila["cod_alterno"].ToString();
                            des_item = fila["des_item"].ToString();
                            cod_grupo = fila["cod_grupo"].ToString();
                            cod_subgrupo = fila["cod_subgrupo"].ToString();
                            pre_vt1 = fila["pre_vt1"].ToString();
                            cod_grupo2 = fila["cod_grupo"].ToString();
                            nom_grupo = fila["nom_grupo"].ToString();
                            cod_grupo3 = fila["cod_grupo"].ToString();
                            cod_subgrupo2 = fila["cod_subgrupo"].ToString();
                            nom_subgrupo = fila["nom_subgrupo"].ToString();

                            listaInventario.Add(new Entities.Inventario(cod_alterno, des_item, cod_grupo, cod_subgrupo, pre_vt1, cod_grupo2, nom_grupo, cod_grupo3, cod_subgrupo2, nom_subgrupo) { });

                        }
                    }

                    return Ok(listaInventario);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
