using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioRest_Entrevista.InputModel
{
    public class ItemNombreGrupo
    {
        [Required]
        public string NombreGrupo { get; set; }

    }
}
