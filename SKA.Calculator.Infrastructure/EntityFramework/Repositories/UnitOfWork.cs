using SKA.Calculator.Domain.Interfaces;
using SKA.Calculator.Infrastructure.EntityFramework.Context;

namespace SKA.Calculator.Infrastructure.EntityFramework.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly HistoryCalculationsDbContext context;
        public ICalculatorRepository? calculatorRepository;

        public UnitOfWork(HistoryCalculationsDbContext context, ICalculatorRepository? calculatorRepository)
        {
            this.context = context;
            this.calculatorRepository = calculatorRepository;
        }

        public ICalculatorRepository CalculatorRepository => calculatorRepository ?? (new CalculatorRepository(context));

        public async Task<bool> Commit()
        {
            var result = await context.SaveChangesAsync();

            if (result == 0)
                return false;
            return true;
        }

        public void Rollback()
        {
            context?.Dispose();
        }
    }
}
