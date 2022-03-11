using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using CertificationManager.Infrastructure.Abstractions.Entities;
using System;
using System.Threading.Tasks;

namespace CertificationManager.Infrastructure.Abstractions.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICertificacionesVolumenesRepository CertificacionesVolumenes { get; set; }

        Task<int> CompleteAsync();
        void DetatchEntity(BaseEntity baseEntity);
    }
}
