using Microsoft.EntityFrameworkCore;
using Rio.Tenis.Backend.Models;

namespace Rio.Tenis.Backend.DBContexts
{
    public class RioTenisDBContext : DbContext
    {
        public DbSet<Zapato> Zapatos { get; set; }
       
        public RioTenisDBContext(DbContextOptions<RioTenisDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Nombres de tablas  
            modelBuilder.Entity<Zapato>().ToTable("Zapatos");

        }
    }
}