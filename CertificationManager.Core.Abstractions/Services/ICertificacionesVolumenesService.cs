using CertificationManager.Core.Abstractions.ComonResult;
using CertificationManager.Core.Abstractions.Dtos;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationManager.Core.Abstractions.Services
{
    public interface ICertificacionesVolumenesService
    {
        Task<ResultDto<ClientesDto>> Get(Guid id);
        Task<ResultDto<bool>> Put(ClientesDto ClientesDto);
        Task<ResultDto<bool>> Delete(Guid id);
        Task<ResultDto<int>> Post(ClientesDto ClientesDto);
        Task<ResultDto<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>> UspWebCertificacionesVolumenesPagoDetallesObtener(int id_certificacion_volumen);
        Task<ResultDto<List<ResponseUspWebPeriodosObtener>>> UspWebPeriodosObtener(int? id_periodo);

    }
}
