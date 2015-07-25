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
    public class TipoTrabajoGradoUnitTest
    {
        [TestMethod]
        public void VerificarInsertarTipoTrabajoGrado()
        {
            TrabajoGrado trabajoGrado = new TrabajoGrado();
            trabajoGrado.IdTrabajoGrado = 0;
            trabajoGrado.TipoTrabajoGrado = "test";
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();

            trabajoGradoRepository.Add(trabajoGrado);
            trabajoGradoRepository.Save();

            var trabajosGrado = trabajoGradoRepository.GetAll().ToList();
            int index = trabajosGrado.FindIndex(x => x.TipoTrabajoGrado == trabajoGrado.TipoTrabajoGrado);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEditarTipoTrabajoGrado()
        {
            TrabajoGrado trabajoGrado = new TrabajoGrado();
            trabajoGrado.IdTrabajoGrado = 0;
            trabajoGrado.TipoTrabajoGrado = "test";
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();

            trabajoGradoRepository.Add(trabajoGrado);
            trabajoGradoRepository.Save();

            trabajoGrado.TipoTrabajoGrado = "test1";
            trabajoGradoRepository.Edit(trabajoGrado);
            trabajoGradoRepository.Save();

            var trabajosGrado = trabajoGradoRepository.GetAll().ToList();
            int index = trabajosGrado.FindIndex(x => x.TipoTrabajoGrado == trabajoGrado.TipoTrabajoGrado);
            Assert.IsTrue(index >= 0);
        }

        [TestMethod]
        public void VerificarEliminarTipoTrabajoGrado()
        {
            TrabajoGrado trabajoGrado = new TrabajoGrado();
            trabajoGrado.IdTrabajoGrado = 0;
            trabajoGrado.TipoTrabajoGrado = "test2";
            ITrabajoGradoRepository trabajoGradoRepository = new TrabajoGradoRepository();

            trabajoGradoRepository.Add(trabajoGrado);
            trabajoGradoRepository.Save();

            var trabajosGrado = trabajoGradoRepository.GetAll().ToList();
            int index = trabajosGrado.FindIndex(x => x.TipoTrabajoGrado == trabajoGrado.TipoTrabajoGrado);
            Assert.IsTrue(index >= 0);
            if (index >= 0)
            {
                trabajoGrado = trabajosGrado[index];
            }

            trabajoGradoRepository.Delete(trabajoGrado);
            trabajoGradoRepository.Save();

            trabajosGrado = trabajoGradoRepository.GetAll().ToList();
            index = trabajosGrado.FindIndex(x => x.TipoTrabajoGrado == trabajoGrado.TipoTrabajoGrado);

            Assert.IsTrue(index == -1);
        }
    }
}
