using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ej1.Models
{
    public class ModelContext : DbContext
    {

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Evento> eventos { get; set; }
        public DbSet<Telefono> telefonos { get; set; }

    }
}