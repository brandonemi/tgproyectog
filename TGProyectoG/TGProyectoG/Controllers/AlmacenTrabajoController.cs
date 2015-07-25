using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TGProyectoG.Business;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;
using TGProyectoG.Dto;

namespace TGProyectoG.Controllers
{
    public class AlmacenTrabajoController : Controller
    {
        private TGProyectoGContext db = new TGProyectoGContext();

        //
        // GET: /AlmacenTrabajo/

        public ActionResult Index()
        {           
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            var listAlmacenTrabajo = almacenTrabajoRepository.GetAllComplete().ToList();
            AlmacenTrabajoSearchDto modelDto = new AlmacenTrabajoSearchDto();
            modelDto.AlmacenTrabajoListResult = listAlmacenTrabajo;
            return View(modelDto);
        }

        //
        // GET: /AlmacenTrabajo/Details/5

        public ActionResult Details(int id = 0)
        {
            AlmacenTrabajo almacentrabajo = db.AlmacenTrabajos.Find(id);
            if (almacentrabajo == null)
            {
                return HttpNotFound();
            }
            return View(almacentrabajo);
        }

        //
        // GET: /AlmacenTrabajo/Create

        public ActionResult Create()
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            ICarreraRepository carreraRepository = new CarreraRepository();
            ITutorRepository tutorRepository = new TutorRepository();
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto modelDto = new AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto();
            modelDto.ListUnidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            modelDto.ListCarreras = carreraRepository.GetAll().ToList();
            modelDto.ListTutores = tutorRepository.GetAll().ToList();
            modelDto.ListTrabajosGrado = trabajoGradoRepository.GetAll().ToList();
            modelDto.FillDropDowns();

            return View(modelDto);
        }

        //
        // POST: /AlmacenTrabajo/Create

        [HttpPost]
        public ActionResult Create(AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto modelDto)
        {
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            ICarreraRepository carreraRepository = new CarreraRepository();
            ITutorRepository tutorRepository = new TutorRepository();
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            if (ModelState.IsValid)
            {
                AlmacenTrabajo almacenTrabajo = modelDto.GetAlmacenTrabajo();
                almacenTrabajoRepository.Add(almacenTrabajo);
                almacenTrabajoRepository.Save();
                return RedirectToAction("Index");
            }

            modelDto.ListUnidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            modelDto.ListCarreras = carreraRepository.GetAll().ToList();
            modelDto.ListTutores = tutorRepository.GetAll().ToList();
            modelDto.ListTrabajosGrado = trabajoGradoRepository.GetAll().ToList();
            modelDto.FillDropDowns();

            return View(modelDto);
        }

        //
        // GET: /AlmacenTrabajo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            ICarreraRepository carreraRepository = new CarreraRepository();
            ITutorRepository tutorRepository = new TutorRepository();
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();

            AlmacenTrabajo almacenTrabajo = almacenTrabajoRepository.GetSingle(id);
            AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto modelDto = new AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto();

            if (almacenTrabajo == null)
            {
                return HttpNotFound();
            }
            modelDto.GetModelDtoFromAlmacenTrabajo(almacenTrabajo);
            modelDto.ListUnidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            modelDto.ListCarreras = carreraRepository.GetAll().ToList();
            modelDto.ListTutores = tutorRepository.GetAll().ToList();
            modelDto.ListTrabajosGrado = trabajoGradoRepository.GetAll().ToList();
            modelDto.FillDropDowns();
            return View(modelDto);
        }

        //
        // POST: /AlmacenTrabajo/Edit/5

        [HttpPost]
        public ActionResult Edit(AlmacenTrabajoCarreraUnidadAcademicaTutorTrabajoGradoDto modelDto)
        {
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            ICarreraRepository carreraRepository = new CarreraRepository();
            ITutorRepository tutorRepository = new TutorRepository();
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();

            if (ModelState.IsValid)
            {
                AlmacenTrabajo almacenTrabajo = modelDto.GetAlmacenTrabajo();
                almacenTrabajoRepository.Edit(almacenTrabajo);
                almacenTrabajoRepository.Save();
                return RedirectToAction("Index");
            }
            modelDto.ListUnidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            modelDto.ListCarreras = carreraRepository.GetAll().ToList();
            modelDto.ListTutores = tutorRepository.GetAll().ToList();
            modelDto.ListTrabajosGrado = trabajoGradoRepository.GetAll().ToList();
            modelDto.FillDropDowns();

            return View(modelDto);
        }

        //
        // GET: /AlmacenTrabajo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            AlmacenTrabajo almacenTrabajo = almacenTrabajoRepository.GetSingle(id);
            if (almacenTrabajo == null)
            {
                return HttpNotFound();
            }
            return View(almacenTrabajo);
        }

        //
        // POST: /AlmacenTrabajo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            IAlmacenTrabajoRepository almacenTrabajoRepository = new AlmacenTrabajoRepository();
            AlmacenTrabajo model = almacenTrabajoRepository.GetSingle(id);
            almacenTrabajoRepository.Delete(model);
            almacenTrabajoRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}