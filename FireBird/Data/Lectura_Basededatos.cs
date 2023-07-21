using DocumentFormat.OpenXml.InkML;
using FireBird.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FireBird.Data
{
    internal class Lectura_Basededatos
    {
        public class DatabaseDbContext : DbContext
        {
            private DbSet<Dato> Datos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string databasePath = "C:\\Datos_Empaque\\Surtido.db"; // Ruta personalizada hacia la base de datos SQLite
                if (!File.Exists(databasePath))
                {
                    File.Create(databasePath).Close();
                }
                optionsBuilder.UseSqlite($"Data Source={databasePath}",
                    sqliteOptionsAction: op =>
                    {
                        op.MigrationsAssembly(
                            Assembly.GetExecutingAssembly().FullName
                            );
                    });
                base.OnConfiguring(optionsBuilder);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Dato>().ToTable("Datos");
                modelBuilder.Entity<Dato>(entity =>
                {
                    entity.HasKey(x => x.BaseId);
                });
            }

        }
    }
}
