using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Taipe14.Models;

namespace Taipe14.DataContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Compra> Comprar { get; set; }



        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}