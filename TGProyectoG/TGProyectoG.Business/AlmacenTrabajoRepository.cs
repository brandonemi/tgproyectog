using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class AlmacenTrabajoRepository : GenericRepository<TGProyectoGContext, AlmacenTrabajo>, IAlmacenTrabajoRepository
    {

        public AlmacenTrabajo GetSingle(int AlmacenTrabajoId)
        {
            var query = from a in Context.AlmacenTrabajos.Include("UnidadAcademica").Include("TrabajoGrado").Include("Tutor").Include("Carrera")
                        where a.IdAlmacenTrabajo == AlmacenTrabajoId
                        select a;
            return query.FirstOrDefault();
        }

        public IEnumerable<AlmacenTrabajo> GetAllComplete()
        {
            var query = from a in Context.AlmacenTrabajos.Include("UnidadAcademica").Include("TrabajoGrado").Include("Tutor").Include("Carrera")
                        select a;
            return query;

        }
    }
}
