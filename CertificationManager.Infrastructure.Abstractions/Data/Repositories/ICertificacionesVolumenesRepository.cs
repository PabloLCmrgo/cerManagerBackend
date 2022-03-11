using CertificationManager.Infrastructure.Abstractions.Entities;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CertificationManager.Infrastructure.Abstractions.Data.Repositories
{
    public interface ICertificacionesVolumenesRepository : IGenericRepository<CertificacionesVolumenes>
    {
        
        Task<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>> UspWebCertificacionesVolumenesPagoDetallesObtener(int id_certificacion_volumen);
    }
}
