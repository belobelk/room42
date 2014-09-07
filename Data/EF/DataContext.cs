using System.Data.Entity;
using Data.Models;

namespace Data.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;

            Database.SetInitializer(new TestDataContext());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    
    }
}
