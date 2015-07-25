using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;
using TGProyectoG.Data;

namespace TGProyectoG.Business
{
    public class UsuarioRepository : GenericRepository<TGProyectoGContext, Usuario>, IUsuarioRepository
    {

        public Usuario GetSingle(int usuarioId)
        {
            var query = GetAll().FirstOrDefault(x => x.IdUsuario == usuarioId);
            return query;
        }

    }
}
