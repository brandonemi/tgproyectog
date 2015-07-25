using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TGProyectoG.Data
{
    public class TGProyectoGContext : DbContext
    {
        public TGProyectoGContext() : base("TGProyectoGConnection")
                
            {

            }

        public DbSet<Rol> Roles { get; set; }

        public DbSet<AlmacenTrabajo> AlmacenTrabajos { get; set; }

        public DbSet<Carrera> Carreras { get; set; }

        public DbSet<TrabajoGrado> TrabajosGrado { get; set; }

        public DbSet<Tutor> Tutores { get; set; }

        public DbSet<UnidadAcademica> UnidadesAcademicas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
