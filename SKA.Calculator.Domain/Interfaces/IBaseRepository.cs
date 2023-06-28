using System.Linq.Expressions;

namespace SKA.Calculator.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
        void Remove(T entity);
        void Update(T entity);

    }
}
