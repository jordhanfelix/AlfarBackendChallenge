using System.Linq.Expressions;

namespace AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> FindByExpression(Expression<Func<T, bool>> expression);
    }
}