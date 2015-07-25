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
    public class TutorController : Controller
    {
        private TGProyectoGContext db = new TGProyectoGContext();

        //
        // GET: /Tutor/

        public ActionResult Index()
        {
            ITutorRepository tutorRepository = new TutorRepository();
            var listTutor = tutorRepository.GetAll().ToList();
            return View(listTutor);
        }

        //
        // GET: /Tutor/Details/5

        public ActionResult Details(int id = 0)
        {
            Tutor tutor = db.Tutores.Find(id);
            if (tutor == null)
            {
                return HttpNotFound();
            }
            return View(tutor);
        }

        //
        // GET: /Tutor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tutor/Create

        [HttpPost]
        public ActionResult Create(Tutor tutor)
        {
            ITutorRepository tutorRepository = new TutorRepository();
            if (ModelState.IsValid)
            {
                tutorRepository.Add(tutor);
                tutorRepository.Save();
                return RedirectToAction("Index");
            }

            return View(tutor);
        }

        //
        // GET: /Tutor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ITutorRepository tutorRepository = new TutorRepository();
            Tutor model = tutorRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Tutor/Edit/5

        [HttpPost]
        public ActionResult Edit(Tutor tutor)
        {
            ITutorRepository tutorRepository = new TutorRepository();
            if (ModelState.IsValid)
            {
                tutorRepository.Edit(tutor);
                tutorRepository.Save();
                return RedirectToAction("Index");
            }
            return View(tutor);
        }

        //
        // GET: /Tutor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ITutorRepository tutorRepository = new TutorRepository();
            Tutor model = tutorRepository.GetSingle(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Tutor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ITutorRepository tutorRepository = new TutorRepository();
            Tutor model = tutorRepository.GetSingle(id);
            tutorRepository.Delete(model);
            tutorRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}