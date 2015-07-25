using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Data;

namespace TGProyectoG.Business.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Usuario GetSingle(int UsuarioId);
    }
}
