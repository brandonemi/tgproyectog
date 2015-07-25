using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class TrabajoGradoRepository : GenericRepository<TGProyectoGContext, TrabajoGrado>, ITrabajoGradoRepository
    {

        public TrabajoGrado GetSingle(int TrabajoGradoId)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTrabajoGrado == TrabajoGradoId);
            return query;
        }

        public IEnumerable<TrabajoGrado> GetListByName(string name)
        {
            var query = GetAll().Where(x => x.TipoTrabajoGrado.Contains(name));
            return query;
        }
    }
}
