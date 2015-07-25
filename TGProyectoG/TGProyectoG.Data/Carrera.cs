using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class Carrera
    {
        [Key]
        [Display(Name = "Id Carrera  ")]
        public int IdCarrera { get; set; }

        [Display(Name = "Carrera  ")]
        public string NombreCarrera { get; set; }
    }
}
