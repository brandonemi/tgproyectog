using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class TutorRepository : GenericRepository<TGProyectoGContext, Tutor>, ITutorRepository
    {

        public Tutor GetSingle(int TutorId)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTutor == TutorId);
            return query;
        }

        public IEnumerable<Tutor> GetListByName(string name)
        {
            var query = GetAll().Where(x => x.Nombre.Contains(name));
            return query;
        }
    }
}
