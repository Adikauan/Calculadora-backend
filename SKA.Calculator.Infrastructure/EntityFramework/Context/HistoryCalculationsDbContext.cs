using Microsoft.EntityFrameworkCore;
using SKA.Calculator.Domain.Aggregates;
using SKA.Calculator.Infrastructure.EntityFramework.Configuration;

namespace SKA.Calculator.Infrastructure.EntityFramework.Context
{
    public class HistoryCalculationsDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = nameof(Calculator);
        DbSet<HistoryCalculations> HistoryCalculations { get; set; } 

        public HistoryCalculationsDbContext(DbContextOptions<HistoryCalculationsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DEFAULT_SCHEMA);

            modelBuilder.ApplyConfiguration(new HistoryCalculationsEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
