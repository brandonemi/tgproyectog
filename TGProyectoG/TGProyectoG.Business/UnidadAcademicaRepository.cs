using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class UnidadAcademicaRepository : GenericRepository<TGProyectoGContext, UnidadAcademica>, IUnidadAcademicaRepository
    {

        public UnidadAcademica GetSingle(int UnidadAcademicaId)
        {
            var query = GetAll().FirstOrDefault(x => x.IdUnidadAcademica == UnidadAcademicaId);
            return query;
        }

        public IEnumerable<UnidadAcademica> GetListByName(string name)
        {
            var query = GetAll().Where(x => x.Departamento.Contains(name));
            return query;
        }
    }
}
