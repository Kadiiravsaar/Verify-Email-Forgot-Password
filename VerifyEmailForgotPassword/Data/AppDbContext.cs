
using System.Reflection;
using VerifyEmailForgotPassword.Models;

namespace VerifyEmailForgotPassword.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // tüm assembly seviyesinde configurationları tarar ve bulur


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users => Set<User>();
    }

}
