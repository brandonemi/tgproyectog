using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class Tutor
    {
        [Key]
        [Display(Name = "Id Tutor  ")]
        public int IdTutor { get; set; }

        [Display(Name = "Nombre  ")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido  ")]
        public string Apellido { get; set; }

        [Display(Name = "Profesion  ")]
        public string Profesion { get; set; }
    }
}
