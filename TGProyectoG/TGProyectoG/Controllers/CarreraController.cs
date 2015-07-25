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
    public class CarreraController : Controller
    {
        private TGProyectoGContext db = new TGProyectoGContext();

        //
        // GET: /Carrera/

        public ActionResult Index()
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            var listCarrera = carreraRepository.GetAll().ToList();
            return View(listCarrera);
        }

        //
        // GET: /Carrera/Details/5

        public ActionResult Details(int id = 0)
        {
            Carrera carrera = db.Carreras.Find(id);
            if (carrera == null)
            {
                return HttpNotFound();
            }
            return View(carrera);
        }

        //
        // GET: /Carrera/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Carrera/Create

        [HttpPost]
        public ActionResult Create(Carrera carrera)
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            if (ModelState.IsValid)
            {
                carreraRepository.Add(carrera);
                carreraRepository.Save();
                return RedirectToAction("Index");
            }

            return View(carrera);
        }

        //
        // GET: /Carrera/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            Carrera model = carreraRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Carrera/Edit/5

        [HttpPost]
        public ActionResult Edit(Carrera carrera)
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            if (ModelState.IsValid)
            {
                carreraRepository.Edit(carrera);
                carreraRepository.Save();
                return RedirectToAction("Index");
            }
            return View(carrera);
        }

        //
        // GET: /Carrera/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            Carrera model = carreraRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Carrera/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ICarreraRepository carreraRepository = new CarreraRepository();
            Carrera model = carreraRepository.GetSingle(id);
            carreraRepository.Delete(model);
            carreraRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}