using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Opgave8_1.Model;
using Lektion8.Context;

namespace Lektion8.Context
{
    class BilContext : DbContext
    {
        public BilContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BALDEAGLEBILL\\SQLEXPRESS; Initial Catalog=Bil; Integrated Security=SSPI; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Ejer ejer1 = new Ejer { EjerID = -1, Ejernavn = "Bill Gates" };
            Ejer ejer2 = new Ejer { EjerID = -2, Ejernavn = "Steve Jobs" };

            Bil bil1 = new Bil { EjerID = -1, BilID = -1, Color = "Red", Manufacturer = "Ford", Plate = "DB12122" };
            Bil bil2 = new Bil { EjerID = -2, BilID = -2, Color = "Blue", Manufacturer = "VW", Plate = "DB12123" };

            modelBuilder.Entity<Ejer>().HasData(ejer1, ejer2);

            modelBuilder.Entity<Bil>().HasData(bil1, bil2);
        }


        public DbSet<Bil> Biler { get; set; }
        public DbSet<Ejer> Ejere { get; set; }
    }
}
