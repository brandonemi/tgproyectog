using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Dto
{
    public class AlmacenTrabajoSearchDto
    {
        public List<AlmacenTrabajo> AlmacenTrabajoListResult { get; set; }

        [Display(Name = "Buscar ")]
        public string SearchString { get; set; }
    }
}
