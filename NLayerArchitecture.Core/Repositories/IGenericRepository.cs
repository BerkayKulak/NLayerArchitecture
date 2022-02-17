using System.Linq.Expressions;

namespace NLayerArchitecture.Core.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        // productrepository.where(x=>x.id>5).orderBy().ToListAsync()
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        
        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity); // asenkron metodu yok

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
