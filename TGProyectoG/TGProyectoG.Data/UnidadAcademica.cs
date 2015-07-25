using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class UnidadAcademica
    {
        [Key]
        [Display(Name = "Id Unidad Academica  ")]
        public int IdUnidadAcademica { get; set; }

        [Display(Name = "Departamento  ")]
        public string Departamento { get; set; }
    }
}
