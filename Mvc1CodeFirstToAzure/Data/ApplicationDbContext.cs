using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mvc1CodeFirstToAzure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=PlayerDatabase;Trusted_Connection=True;");
            }
        }

        public DbSet<Player> Players { get; set; }


    }
}