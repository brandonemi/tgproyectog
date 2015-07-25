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
    public class TrabajoGradoController : Controller
    {
        private TGProyectoGContext db = new TGProyectoGContext();

        //
        // GET: /TrabajoGrado/

        public ActionResult Index()
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            var listTrabajoGrado = trabajoGradoRepository.GetAll().ToList();
            return View(listTrabajoGrado);
        }

        //
        // GET: /TrabajoGrado/Details/5

        public ActionResult Details(int id = 0)
        {
            TrabajoGrado trabajogrado = db.TrabajosGrado.Find(id);
            if (trabajogrado == null)
            {
                return HttpNotFound();
            }
            return View(trabajogrado);
        }

        //
        // GET: /TrabajoGrado/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TrabajoGrado/Create

        [HttpPost]
        public ActionResult Create(TrabajoGrado trabajogrado)
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            if (ModelState.IsValid)
            {
                trabajoGradoRepository.Add(trabajogrado);
                trabajoGradoRepository.Save();
                return RedirectToAction("Index");
            }

            return View(trabajogrado);
        }

        //
        // GET: /TrabajoGrado/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            TrabajoGrado model = trabajoGradoRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /TrabajoGrado/Edit/5

        [HttpPost]
        public ActionResult Edit(TrabajoGrado trabajogrado)
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            if (ModelState.IsValid)
            {
                trabajoGradoRepository.Edit(trabajogrado);
                trabajoGradoRepository.Save();
                return RedirectToAction("Index");
            }
            return View(trabajogrado);
        }

        //
        // GET: /TrabajoGrado/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            TrabajoGrado model = trabajoGradoRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /TrabajoGrado/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();
            TrabajoGrado model = trabajoGradoRepository.GetSingle(id);
            trabajoGradoRepository.Delete(model);
            trabajoGradoRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}