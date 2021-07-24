
using Jokenpo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jokenpo.API.Data
{
    public class JokenpoContext : DbContext
    {
        public JokenpoContext(DbContextOptions<JokenpoContext> options) : base(options)
        {            
        }

        public DbSet<Ranking> Rankings{ get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ranking>()
                .HasKey(r=> new {r.Id});
        }
    }
}