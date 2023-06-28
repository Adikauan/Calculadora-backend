using Microsoft.EntityFrameworkCore;
using SKA.Calculator.Domain.Interfaces;
using SKA.Calculator.Infrastructure.EntityFramework.Context;
using System.Linq.Expressions;

namespace SKA.Calculator.Infrastructure.EntityFramework.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly HistoryCalculationsDbContext context;

        public BaseRepository(HistoryCalculationsDbContext context) => this.context = context;

        public void Add(T entity) => context.Set<T>().Add(entity);

        public async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate) => await context.Set<T>().FirstOrDefaultAsync(predicate);

        public void Remove(T entity) => context.Set<T>().Remove(entity);

        public void Update(T entity) => context.Set<T>().Update(entity);
    }
}
