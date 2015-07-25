namespace TGProyectoG.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<TGProyectoG.Data.TGProyectoGContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TGProyectoG.Data.TGProyectoGContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            WebSecurity.InitializeDatabaseConnection(
           "TGProyectoGConnection",
           "Usuarios",
           "IdUsuario",
           "Login", autoCreateTables: true);
            if (!Roles.RoleExists("Administrador"))
                Roles.CreateRole("Administrador");
            if (!Roles.RoleExists("Jefe de Carrera"))
                Roles.CreateRole("Jefe de Carrera");
            if (!Roles.RoleExists("Bibliotecario"))
                Roles.CreateRole("Bibliotecario");
            if (!Roles.RoleExists("Docente/Estudiante"))
                Roles.CreateRole("Docente/Estudiante");
            if (!WebSecurity.UserExists("bortuno"))
                WebSecurity.CreateUserAndAccount(
                    "bortuno",
                    "12345",
                    new { Nombre = "Administrador", Apellido = "Administrador", Codigo = "Administrador", RolAcademico = "Administrador"});

            if (!Roles.GetRolesForUser("bortuno").Contains("Administrador"))
                Roles.AddUsersToRoles(new[] { "bortuno" }, new[] { "Administrador" });
        }
    }
}
