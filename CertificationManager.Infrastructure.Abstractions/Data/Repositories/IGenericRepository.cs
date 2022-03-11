using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CertificationManager.Infrastructure.Abstractions.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdWithTrackingAsync(Guid id);
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity, TEntity entity1 = null);

        void UpdateRange(List<TEntity> updateEntities);
    }
}