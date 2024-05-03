using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.SqlServerDbContext
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = Localhost;Initial Catalog= N-TierDB;Integrated Security = true; Encrypt =false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Car> Cars { get; set; }
    }
}
