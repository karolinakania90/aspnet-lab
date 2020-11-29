using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Database {
    public class ExchangesDbContext : DbContext {

        public ExchangesDbContext(DbContextOptions options) : base(options) {

        }

        public DbSet<ItemEntity> ItemEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            // fluent configuration ...
        }

    }
}
