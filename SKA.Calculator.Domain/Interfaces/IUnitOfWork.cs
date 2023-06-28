namespace SKA.Calculator.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICalculatorRepository CalculatorRepository { get; }
        Task<bool> Commit();
        void Rollback();
    }
}
