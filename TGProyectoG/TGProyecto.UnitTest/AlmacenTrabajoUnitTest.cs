﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TGProyectoG.Data;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Business;
using System.Linq;
using System.Collections.Generic;
using TGProyectoG.Dto;

namespace TGProyecto.UnitTest
{
    [TestClass]
    public class AlmacenTrabajoUnitTest
    {
        [TestMethod]
        public void VerificarInsertarAlmacenTrabajo()
        {
            UnidadAcademica unidadAcademica = new UnidadAcademica();
            unidadAcademica.IdUnidadAcademica = 0;
            unidadAcademica.Departamento = "test";
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();

            unidadAcademicaRepository.Add(unidadAcademica);
            unidadAcademicaRepository.Save();

            var unidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            int index = unidadesAcademicas.FindIndex(x => x.Departamento == unidadAcademica.Departamento);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEditarAlmacenTrabajo()
        {
            UnidadAcademica unidadAcademica = new UnidadAcademica();
            unidadAcademica.IdUnidadAcademica = 0;
            unidadAcademica.Departamento = "test";
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            unidadAcademicaRepository.Add(unidadAcademica);
            unidadAcademicaRepository.Save();

            unidadAcademica.Departamento = "test1";
            unidadAcademicaRepository.Edit(unidadAcademica);
            unidadAcademicaRepository.Save();

            var unidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            int index = unidadesAcademicas.FindIndex(x => x.Departamento == unidadAcademica.Departamento);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEliminarAlmacenTrabajo()
        {
            UnidadAcademica unidadAcademica = new UnidadAcademica();
            unidadAcademica.IdUnidadAcademica = 0;
            unidadAcademica.Departamento = "test2";
            IUnidadAcademicaRepository unidadAcademicaRepository = new UnidadAcademicaRepository();
            unidadAcademicaRepository.Add(unidadAcademica);
            unidadAcademicaRepository.Save();

            var unidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            int index = unidadesAcademicas.FindIndex(x => x.Departamento == unidadAcademica.Departamento);
            if (index >= 0)
            {
                unidadAcademica = unidadesAcademicas[index];
            }

            unidadAcademicaRepository.Delete(unidadAcademica);
            unidadAcademicaRepository.Save();

            unidadesAcademicas = unidadAcademicaRepository.GetAll().ToList();
            index = unidadesAcademicas.FindIndex(x => x.Departamento == unidadAcademica.Departamento);

            Assert.IsTrue(index == -1);
        }
    }
}
