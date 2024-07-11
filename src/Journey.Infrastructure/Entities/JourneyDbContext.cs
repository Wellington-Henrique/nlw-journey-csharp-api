using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure.Entities
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Projetos\\NLW Journey\\src\\Journey.Infrastructure\\JourneyDatabase.db");
        }

        // Esta função pode ser usada em outros tipos de banco como MySQL, SQL server para um join entre Trips e Activities ao atualizar um cadastro de Trip
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Activity>().ToTable("Activities");
        //}
    }
}
