using FreightAppASP.Models;
using Microsoft.Data.Entity;
using System.IO;

namespace FreightAppASP.DataContexts
{
    public class CarrierContext : DbContext
    {
        public DbSet<Carrier> Carriers { get; set; } 
        public DbSet<Lanes> Lanes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dataDirectory = Path.Combine(Startup.WebRootPath, "App_Data");

            options.UseSqlite(@"Data Source=" + dataDirectory + System.IO.Path.DirectorySeparatorChar + @"FreightAppASP.db;");
        }
    }
}
