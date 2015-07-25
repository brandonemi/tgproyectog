using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class TrabajoGrado
    {
        [Key]
        [Display(Name = "Id Trabajo de Grado  ")]
        public int IdTrabajoGrado { get; set; }

        [Display(Name = "Tipo de Trabajo de Grado  ")]
        public string TipoTrabajoGrado { get; set; }
    }
}
