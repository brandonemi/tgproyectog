using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface ITutorRepository : IGenericRepository<Tutor>
    {
        Tutor GetSingle(int TutorId);
        IEnumerable<Tutor> GetListByName(string name);
    }
}
