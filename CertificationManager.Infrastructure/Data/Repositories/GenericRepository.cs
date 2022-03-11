using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using CertificationManager.Infrastructure.Data.DBContexts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore.ChangeTracking;
using CertificationManager.Infrastructure.Abstractions.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CertificationManager.Infrastructure.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> entities;
        protected readonly DbContext context;
        //protected readonly OxxoGasContext oxxoGasContext;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        /*
        public GenericRepository(OxxoGasContext oxxoGasContext)
        {
            this.oxxoGasContext = oxxoGasContext;
            entities = oxxoGasContext.Set<TEntity>();
        }*/

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var entity = await entities.FindAsync(id);
            if (entity != null)
                this.context.Entry(entity).State = EntityState.Detached;
            return entity;

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdWithTrackingAsync(Guid id)
        {
            var entity = await entities.FindAsync(id);
            this.context.Entry(entity).State = EntityState.Unchanged;
            return entity;
        }

        public async Task AddAsync(TEntity entity)
        {
            entities.Add(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            this.entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.entities.RemoveRange(entities);
        }

        public virtual void Update(TEntity entity, TEntity entity1 = null)
        {
            if (entity1 == null)
            {
                //entities.Update(entity);
                context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                context.Entry(entity1).CurrentValues.SetValues(entity);
            }
        }

        public void UpdateRange(List<TEntity> updateEntities)
        {
            //entities.UpdateRange(updateEntities);
            foreach (var entity in updateEntities)
            {
                Update(entity);
            }
        }
    }
}
