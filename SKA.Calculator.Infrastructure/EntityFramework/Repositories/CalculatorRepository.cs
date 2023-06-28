using SKA.Calculator.Domain.Aggregates;
using SKA.Calculator.Domain.Interfaces;
using SKA.Calculator.Infrastructure.EntityFramework.Context;

namespace SKA.Calculator.Infrastructure.EntityFramework.Repositories
{
    public class CalculatorRepository : BaseRepository<HistoryCalculations>, ICalculatorRepository
    {
        public CalculatorRepository(HistoryCalculationsDbContext context) : base(context)
        {
        }
    }
}
