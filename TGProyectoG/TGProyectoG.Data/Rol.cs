using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class Rol
    {
        [Key]
        [Display(Name = "Role Id  ")]
        public int IdRol { get; set; }

        [Display(Name = "RoleName  ")]
        public string Nombre { get; set; }

        [Display(Name = "Role Description  ")]
        public string Descripcion { get; set; }

        [Display(Name = "Is System  ")]
        public Nullable<bool> IsSystem { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
