using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class CarreraRepository : GenericRepository<TGProyectoGContext, Carrera>, ICarreraRepository
    {

        public Carrera GetSingle(int CarreraId)
        {
            var query = GetAll().FirstOrDefault(x => x.IdCarrera == CarreraId);
            return query;
        }

        public IEnumerable<Carrera> GetListByName(string name)
        {
            var query = GetAll().Where(x => x.NombreCarrera.Contains(name));
            return query;
        }
    }
}
