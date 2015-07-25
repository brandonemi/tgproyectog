using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TGProyectoG.Data;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Business;
using System.Linq;
using System.Collections.Generic;

namespace TGProyecto.UnitTest
{
    [TestClass]
    public class TutorUnitTest
    {
        [TestMethod]
        public void VerificarInsertarTutor()
        {
            Tutor tutor = new Tutor();
            tutor.IdTutor = 0;
            tutor.Nombre = "test";
            tutor.Apellido = "test1";
            tutor.Profesion = "test2";
            ITutorRepository tutorRepository = new TutorRepository();
            tutorRepository.Add(tutor);
            tutorRepository.Save();

            var tutores = tutorRepository.GetAll().ToList();
            int index = tutores.FindIndex(x => x.Nombre == tutor.Nombre);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEditarTutor()
        {
            Tutor tutor = new Tutor();
            tutor.IdTutor = 0;
            tutor.Nombre = "test";
            tutor.Apellido = "test1";
            tutor.Profesion = "test2";
            ITutorRepository tutorRepository = new TutorRepository();
            tutorRepository.Add(tutor);
            tutorRepository.Save();

            tutor.Nombre = "test1";
            tutor.Apellido = "test2";
            tutor.Profesion = "test3";
            tutorRepository.Edit(tutor);
            tutorRepository.Save();

            var tutores = tutorRepository.GetAll().ToList();
            int index = tutores.FindIndex(x => x.Nombre == tutor.Nombre);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEliminarTutor()
        {
            Tutor tutor = new Tutor();
            tutor.IdTutor = 0;
            tutor.Nombre = "test2";
            tutor.Apellido = "test3";
            tutor.Profesion = "test4";
            ITutorRepository tutorRepository = new TutorRepository();
            tutorRepository.Add(tutor);
            tutorRepository.Save();

            var tutores = tutorRepository.GetAll().ToList();
            int index = tutores.FindIndex(x => x.Nombre == tutor.Nombre);
            if (index >= 0)
            {
                tutor = tutores[index];
            }
            tutorRepository.Delete(tutor);
            tutorRepository.Save();

            tutores = tutorRepository.GetAll().ToList();
            index = tutores.FindIndex(x => x.Nombre == tutor.Nombre);

            Assert.IsTrue(index == -1);
        }
    }
}
