using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Manual.Models
{
    public class ManualContext : DbContext
    {
        public ManualContext() : base("cadenaConexion") { }

        public DbSet<Aprendiz> Aprendices { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
    }
}