using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure.Entities
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        //public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Projetos\\NLW Journey\\src\\Journey.Infrastructure\\JourneyDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().ToTable("Activities");
        }
    }
}
