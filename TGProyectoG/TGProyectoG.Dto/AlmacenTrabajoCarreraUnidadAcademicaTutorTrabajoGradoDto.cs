using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TGProyectoG.Data;

namespace TGProyectoG.Dto
{
    public class AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto
    {
        public AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto()
        {
            DropDownCarrera = new List<SelectListItem>();
            DropDownUnidadAcademica = new List<SelectListItem>();
            DropDownTutor = new List<SelectListItem>();
            DropDownTrabajoGrado = new List<SelectListItem>();
        }

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

        public List<SelectListItem> DropDownCarrera { get; set; }

        public List<Carrera> ListCarreras { get; set; }

        public List<SelectListItem> DropDownUnidadAcademica { get; set; }

        public List<UnidadAcademica> ListUnidadesAcademicas { get; set; }
        
        public List<SelectListItem> DropDownTutor{ get; set; }

        public List<Tutor> ListTutores { get; set; }

        public List<SelectListItem> DropDownTrabajoGrado { get; set; }

        public List<TrabajoGrado> ListTrabajosGrado { get; set; }

        public void FillDropDowns()
        {
            foreach (var item in ListCarreras)
            {
                DropDownCarrera.Add(new SelectListItem { Value = item.IdCarrera.ToString(), Text = item.NombreCarrera });

            }

            foreach (var item2 in ListUnidadesAcademicas)
            {
                DropDownUnidadAcademica.Add(new SelectListItem { Value = item2.IdUnidadAcademica.ToString(), Text = item2.Departamento });

            }

            foreach (var item3 in ListTutores)
            {
                DropDownTutor.Add(new SelectListItem { Value = item3.IdTutor.ToString(), Text = item3.Nombre + " " + item3.Apellido });

            }
            foreach (var item4 in ListTrabajosGrado)
            {
                DropDownTrabajoGrado.Add(new SelectListItem { Value = item4.IdTrabajoGrado.ToString(), Text = item4.TipoTrabajoGrado });
            }
        }

        public AlmacenTrabajo GetAlmacenTrabajo()
        {
            AlmacenTrabajo almacenTrabajo = new AlmacenTrabajo();
            almacenTrabajo.IdAlmacenTrabajo = this.IdAlmacenTrabajo;
            almacenTrabajo.IdCarrera = this.IdCarrera;
            almacenTrabajo.IdUnidadAcademica = this.IdUnidadAcademica;
            almacenTrabajo.IdTrabajoGrado = this.IdTrabajoGrado;
            almacenTrabajo.IdTutor = this.IdTutor;
            almacenTrabajo.Gestion = this.Gestion;
            almacenTrabajo.Semestre = this.Semestre;
            almacenTrabajo.Titulo = this.Titulo;
            almacenTrabajo.ResumenEjecutivo = this.ResumenEjecutivo;
            almacenTrabajo.ObjetivoGeneral = this.ObjetivoGeneral;
            almacenTrabajo.NombreAutor = this.NombreAutor;
            almacenTrabajo.ApellidoAutor = this.ApellidoAutor;
            return almacenTrabajo;

        }

        public void GetModelDtoFromAlmacenTrabajo(AlmacenTrabajo almacenTrabajo)
        {
            this.IdAlmacenTrabajo = almacenTrabajo.IdAlmacenTrabajo;
            this.IdCarrera = almacenTrabajo.IdCarrera;
            this.IdUnidadAcademica = almacenTrabajo.IdUnidadAcademica;
            this.IdTrabajoGrado = almacenTrabajo.IdTrabajoGrado;
            this.IdTutor = almacenTrabajo.IdTutor;
            this.Gestion = almacenTrabajo.Gestion;
            this.Semestre = almacenTrabajo.Semestre;
            this.Titulo = almacenTrabajo.Titulo;
            this.ResumenEjecutivo = almacenTrabajo.ResumenEjecutivo;
            this.ObjetivoGeneral = almacenTrabajo.ObjetivoGeneral;
            this.NombreAutor = almacenTrabajo.NombreAutor;
            this.ApellidoAutor = almacenTrabajo.ApellidoAutor;
        }
    }
}
