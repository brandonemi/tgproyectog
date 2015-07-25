using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class AlmacenTrabajo
    {
        [Key]
        [Display(Name = "Id Almacen Trabajos  ")]
        public int IdAlmacenTrabajo { get; set; }

        [Display(Name = "Gestion  ")]
        public string Gestion { get; set; }

        [Display(Name = "Semestre  ")]
        public string Semestre { get; set; }

        [Display(Name = "Titulo  ")]
        public string Titulo { get; set; }

        [Display(Name = "Resumen Ejecutivo  ")]
        public string ResumenEjecutivo { get; set; }

        [Display(Name = "Objetivo General  ")]
        public string ObjetivoGeneral { get; set; }

        [Display(Name = "Nombre Autor  ")]
        public string NombreAutor { get; set; }

        [Display(Name = "Apellido Autor  ")]
        public string ApellidoAutor { get; set; }

        public int IdTutor { get; set; }

        public Tutor Tutor { get; set; }

        public int IdUnidadAcademica { get; set; }

        public UnidadAcademica UnidadAcademica { get; set; }

        public int IdTrabajoGrado { get; set; }

        public TrabajoGrado TrabajoGrado { get; set; }

        public int IdCarrera { get; set; }

        public Carrera Carrera { get; set; }

        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
