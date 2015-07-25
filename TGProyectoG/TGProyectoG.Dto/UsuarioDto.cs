using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TGProyectoG.Data;

namespace TGProyectoG.Dto
{
    public class UsuarioDto
    {
        [Key]
        [Required]
        public int IdUsuario { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }


        [Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public string RolAcademico { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        //public string TipoPersona { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme Contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden!")]
        public string ConfirmPassword { get; set; }

        public Usuario getUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = this.Nombre;
            usuario.Apellido = this.Apellido;
            usuario.Codigo = this.Codigo;
            usuario.RolAcademico = this.RolAcademico;
            usuario.Login = this.Login;
            usuario.Password = this.Password;
            return usuario;
        }
    }
}
