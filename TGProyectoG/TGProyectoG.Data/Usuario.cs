using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Id Usuario  ")]
        public int IdUsuario { get; set; }

        [Display(Name = "Nombre  ")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido  ")]
        public string Apellido { get; set; }

        [Display(Name = "Codigo  ")]
        public string Codigo { get; set; }

        [Display(Name = "Rol Academico ")]
        public string RolAcademico { get; set; }

        [Display(Name = "Login  ")]
        public string Login { get; set; }

        [Display(Name = "Password  ")]
        public string Password { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }
    }
}
