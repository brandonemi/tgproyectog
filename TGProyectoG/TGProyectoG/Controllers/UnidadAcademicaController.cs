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

namespace TGProyectoG.Controllers
{
    public class UnidadAcademicaController : Controller
    {
        private TGProyectoGContext db = new TGProyectoGContext();

        //
        // GET: /UnidadAcademica/

        public ActionResult Index()
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            var listUnidadAcademica = unidadAcademicaRepository.GetAll().ToList();
            return View(listUnidadAcademica);
        }

        //
        // GET: /UnidadAcademica/Details/5

        public ActionResult Details(int id = 0)
        {
            UnidadAcademica unidadacademica = db.UnidadesAcademicas.Find(id);
            if (unidadacademica == null)
            {
                return HttpNotFound();
            }
            return View(unidadacademica);
        }

        //
        // GET: /UnidadAcademica/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UnidadAcademica/Create

        [HttpPost]
        public ActionResult Create(UnidadAcademica unidadacademica)
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            if (ModelState.IsValid)
            {
                unidadAcademicaRepository.Add(unidadacademica);
                unidadAcademicaRepository.Save();
                return RedirectToAction("Index");
            }

            return View(unidadacademica);
        }

        //
        // GET: /UnidadAcademica/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            UnidadAcademica model = unidadAcademicaRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /UnidadAcademica/Edit/5

        [HttpPost]
        public ActionResult Edit(UnidadAcademica unidadacademica)
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            if (ModelState.IsValid)
            {
                unidadAcademicaRepository.Edit(unidadacademica);
                unidadAcademicaRepository.Save();
                return RedirectToAction("Index");
            }
            return View(unidadacademica);
        }

        //
        // GET: /UnidadAcademica/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            UnidadAcademica model = unidadAcademicaRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /UnidadAcademica/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            UnidadAcademica model = unidadAcademicaRepository.GetSingle(id);
            unidadAcademicaRepository.Delete(model);
            unidadAcademicaRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}