using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface IUnidadAcademicaRepository : IGenericRepository<UnidadAcademica>
    {
        UnidadAcademica GetSingle(int UnidadAcademicaId);
        IEnumerable<UnidadAcademica> GetListByName(string name);
    }
}
