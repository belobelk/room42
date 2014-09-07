using System.Data.Entity;
using Data.Models;

namespace Data.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderOptions> OrderOptionses { get; set; }
        public DbSet<ApplicationOptions> ApplicationOptionses { get; set; }
        public DbSet<TimeInterval> TimeIntervals { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;

            Database.SetInitializer(new TestDataContext());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderOptions>().HasMany<TimeInterval>(x=>x.GameBreaks);
            modelBuilder.Entity<ApplicationOptions>().HasMany<TimeInterval>(x=>x.WeekdayCostIntervals);
            modelBuilder.Entity<ApplicationOptions>().HasMany<TimeInterval>(x=>x.WeekendCostIntervals);
        }
    
    }
}
