using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=postgres");
        }
    }
}