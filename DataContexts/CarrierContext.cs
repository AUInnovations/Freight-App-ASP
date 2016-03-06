using FreightAppASP.Models;
using Microsoft.Data.Entity;

namespace FreightAppASP.DataContexts
{
    public class CarrierContext : DbContext
    {
        public DbSet<Carrier> Carriers { get; set; } 
    }
}
