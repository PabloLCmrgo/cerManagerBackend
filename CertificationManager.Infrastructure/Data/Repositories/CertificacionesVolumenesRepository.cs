
using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using CertificationManager.Infrastructure.Abstractions.Entities;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using CertificationManager.Infrastructure.Data.DBContexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CertificationManager.Infrastructure.Data.Repositories
{
    public class CertificacionesVolumenesRepository : GenericRepository<CertificacionesVolumenes>, ICertificacionesVolumenesRepository
    {
        public CertificacionesVolumenesRepository(SGDObrasContext context) : base(context)
        {

        }

        public async Task<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>> UspWebCertificacionesVolumenesPagoDetallesObtener(int id_certificacion_volumen)
        {
            SqlParameter CodCli = new SqlParameter("@id_certificacion_volumen", id_certificacion_volumen);
            CodCli.Direction = ParameterDirection.Input;
            var tipo = new List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>();
            tipo = await (this.context as SGDObrasContext).UspWebCertificacionesVolumenesPagoDetallesObtener
                .FromSqlRaw($"exec [cer].[usp_web_certificaciones_volumenes_pago_detalles_obtener] @id_certificacion_volumen = {id_certificacion_volumen} with RECOMPILE").ToListAsync();

            return tipo;
        }

        public async Task<List<ResponseUspWebPeriodosObtener>> UspWebPeriodosObtener(int? id_periodo)
        {

            var tipo = new List<ResponseUspWebPeriodosObtener>();
            tipo = await (this.context as SGDObrasContext).UspWebPeriodosObtener
                .FromSqlRaw(id_periodo != null ? $"exec [cer].[usp_web_periodos_obtener] @id_periodo = {id_periodo} with RECOMPILE":
                $"exec [cer].[usp_web_periodos_obtener] with RECOMPILE").ToListAsync();

            return tipo;
        }
    }
}
