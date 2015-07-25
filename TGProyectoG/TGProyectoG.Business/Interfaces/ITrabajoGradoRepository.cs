using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface ITrabajoGradoRepository : IGenericRepository<TrabajoGrado>
    {
        TrabajoGrado GetSingle(int TrabajoGradoId);
        IEnumerable<TrabajoGrado> GetListByName(string name);
    }
}
