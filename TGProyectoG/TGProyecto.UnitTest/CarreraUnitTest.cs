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
    public class CarreraUnitTest
    {
        [TestMethod]
        public void VerificarInsertarCarrera()
        {
            Carrera carrera = new Carrera();
            carrera.IdCarrera = 0;
            carrera.NombreCarrera = "test";
            ICarreraRepository carreraRepository = new CarreraRepository();
            carreraRepository.Add(carrera);
            carreraRepository.Save();

            var carreras = carreraRepository.GetAll().ToList();
            int index = carreras.FindIndex(x => x.NombreCarrera == carrera.NombreCarrera);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEditarCarrera()
        {
            Carrera carrera = new Carrera();
            carrera.IdCarrera = 0;
            carrera.NombreCarrera = "test";
            ICarreraRepository carreraRepository = new CarreraRepository();
            carreraRepository.Add(carrera);
            carreraRepository.Save();

            carrera.NombreCarrera = "test1";
            carreraRepository.Edit(carrera);
            carreraRepository.Save();

            var carreras = carreraRepository.GetAll().ToList();
            int index = carreras.FindIndex(x => x.NombreCarrera == carrera.NombreCarrera);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEliminarCarrera()
        {
            Carrera carrera = new Carrera();
            carrera.IdCarrera = 0;
            carrera.NombreCarrera = "test2";
            ICarreraRepository carreraRepository = new CarreraRepository();
            carreraRepository.Add(carrera);
            carreraRepository.Save();
           
            var carreras = carreraRepository.GetAll().ToList();
            int index = carreras.FindIndex(x => x.NombreCarrera == carrera.NombreCarrera);
            if (index >= 0)
            {
                carrera = carreras[index];
            }
            carreraRepository.Delete(carrera);
            carreraRepository.Save();

            carreras = carreraRepository.GetAll().ToList();
            index = carreras.FindIndex(x => x.NombreCarrera == carrera.NombreCarrera);

            Assert.IsTrue(index == -1);
        }
    }
}
