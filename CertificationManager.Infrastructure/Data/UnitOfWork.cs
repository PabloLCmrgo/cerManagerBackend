using CertificationManager.Infrastructure.Abstractions.Data;
using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using CertificationManager.Infrastructure.Abstractions.Entities;
using CertificationManager.Infrastructure.Abstractions.Security;
using CertificationManager.Infrastructure.Data.DBContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CertificationManager.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SGDObrasContext context;
        //private readonly ILogger<UnitOfWork> logger;
        public ICertificacionesVolumenesRepository CertificacionesVolumenes { get; set; }

        //public ISecurityBuilder SecurityBuilder { get; }
        public UnitOfWork(SGDObrasContext context,
        ICertificacionesVolumenesRepository CertificacionesVolumenes
        //ISecurityBuilder securityBuilder,
        //    ILogger<UnitOfWork> logger
           )
        {
            this.context = context;
           // this.logger = logger;

            //SecurityBuilder = securityBuilder;
            this.CertificacionesVolumenes = CertificacionesVolumenes;
        }

        public void DetatchEntity(BaseEntity baseEntity)
        {
            this.context.Entry(baseEntity).State = EntityState.Detached;
        }

        public async Task<int> CompleteAsync()
        {
            var entries = context.ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
            //var user = SecurityBuilder.Build().Email();
            /*
            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    if (((BaseEntity)entityEntry.Entity).CreatedOn == DateTimeOffset.MinValue)
                    {
                        ((BaseEntity)entityEntry.Entity).CreatedOn = DateTime.Now;
                    }

                    if (string.IsNullOrEmpty(((BaseEntity)entityEntry.Entity).CreatedBy) && !string.IsNullOrEmpty(user))
                    {
                        ((BaseEntity)entityEntry.Entity).CreatedBy = user;
                    }
                }
                else if (entityEntry.State == EntityState.Modified)
                {
                    if (((BaseEntity)entityEntry.Entity).ModifiedOn == null)
                    {
                        ((BaseEntity)entityEntry.Entity).ModifiedOn = DateTime.Now;
                    }
                    if (string.IsNullOrEmpty(((BaseEntity)entityEntry.Entity).ModifiedBy) && !string.IsNullOrEmpty(user))
                    {
                        ((BaseEntity)entityEntry.Entity).ModifiedBy = user;
                    }

                }
            }
            */
            int result = await context.SaveChangesAsync();
            //logger.LogInformation($"{nameof(ControlGasWebNet)} DBContext SaveChanges successfully");
            return result;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        /*
        private void AuditEntry(EntityEntry entry)
        {
            if (entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                return;

            var auditEntry = new AuditEntry();
            string tableName = entry.Metadata.GetTableName();
            Guid? entryId = null;
            if(entry.Entity is BaseEntity entity)
            {
                entryId = entity.Id;
            }

            auditEntry.TableName = tableName;
            auditEntry.ActionType = entry.State.ToString();            
            foreach (var property in entry.Properties)
            {
                if (property.IsTemporary)
                {
                    continue;
                }

                string propertyName = property.Metadata.Name;
                if (property.Metadata.IsKey())
                    auditEntry.Keys.TryAdd(propertyName, property.CurrentValue);
                switch (entry.State)
                {
                    case EntityState.Added:
                        auditEntry.Values[propertyName] = property.CurrentValue;
                        break;

                    case EntityState.Deleted:
                        auditEntry.Values[propertyName] = property.OriginalValue;
                        break;

                    case EntityState.Modified:
                        if (property.IsModified || property.Metadata.IsPrimaryKey())
                        {
                            auditEntry.Values[propertyName] = property.CurrentValue;
                        }
                        break;
                }
            }
            using (LogContext.PushProperty(SharedResources.AuditIdLogPropertyName, entryId))
            {
                using (LogContext.PushProperty(SharedResources.AuditNameLogPropertyName, tableName))
                {
                    logger.LogInformation($"{nameof(TripDbContext)} DBContext audit info entityName:{tableName} entryId {entryId} data:{JsonConvert.SerializeObject(auditEntry)}");
                }
            }
        }*/

    }
}
