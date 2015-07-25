using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface IAlmacenTrabajoRepository : IGenericRepository<AlmacenTrabajo>
    {
        AlmacenTrabajo GetSingle(int AlmacenTrabajoId);

        IEnumerable<AlmacenTrabajo> GetAllComplete();
    }
}
