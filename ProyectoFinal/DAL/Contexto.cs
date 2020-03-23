using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Factura.db");
        }
    }
}
