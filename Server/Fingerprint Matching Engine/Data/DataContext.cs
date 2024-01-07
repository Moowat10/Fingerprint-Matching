using FingerprintMatchingEngine.Models;
using Microsoft.EntityFrameworkCore;

namespace FingerprintMatchingEngine.Data
{
    public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
            }

            // Define the DbSets
            public DbSet<Finger> Fingers { get; set; }
         
        }
}
