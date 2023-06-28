using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _Calculator = SKA.Calculator.Domain.Aggregates.HistoryCalculations;

namespace SKA.Calculator.Infrastructure.EntityFramework.Configuration
{
    public class HistoryCalculationsEntityConfiguration : IEntityTypeConfiguration<_Calculator>
    {
        public void Configure(EntityTypeBuilder<_Calculator> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.Property(x => x.Operation)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Result)
                .IsRequired();
            builder.Property(x => x.DateTime)
                .IsRequired();
        }
    }
}
