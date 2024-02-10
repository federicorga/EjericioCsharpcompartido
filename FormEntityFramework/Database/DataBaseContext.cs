using FormEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEntityFramework.Database
{
    public class DataBaseContext :DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // esto se va a utilizar para que el contexto sepa con que base de datos esta trabajando. Lo usa internamente el contexto
        {
            string server = "localhost";
            string dataBase = "coderEntityMigration";

            optionsBuilder.UseSqlServer($"Server={server};Database={dataBase};Trusted_Connection=true;");
        }
    }
}
