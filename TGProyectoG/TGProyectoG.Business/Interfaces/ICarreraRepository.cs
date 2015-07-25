using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface ICarreraRepository : IGenericRepository<Carrera>
    {
        Carrera GetSingle(int CarreraId);
        IEnumerable<Carrera> GetListByName(string name);
    }
}
