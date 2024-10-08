using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using C4_ENTIDAD;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace DAL
{

    //las actividades se registran por dia, asi cuando se marca se descuenta un dia y automaticamente se guarda en la base de datos.

    public class Conexion : DbContext
    {
        public Conexion() : base("Conexion")
        {
        }
        //Si no quieres que Entity Framework verifique la existencia de una base de datos, 
        //puedes especificar que debe crear la base de datos usando el método Database.SetInitializer en tu clase DbContext:
        // Database.SetInitializer<Conexion>(new CreateDatabaseIfNotExists<Conexion>());
        public DbSet<Manager> Managers { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<EntryHistory> EntryHistories { get; set; }
        public DbSet<Entry> Entries { get; set; }

    }
}