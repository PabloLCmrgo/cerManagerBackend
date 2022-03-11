using CertificationManager.Core.Abstractions.ComonResult;
using CertificationManager.Core.Abstractions.Services;
using CertificationManager.Core.Services;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CertificationManager.Api.v1.Controllers
{

    //[ApiVersion("1")]
    public class CertificacionesController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CertificacionesController> _logger;
        private readonly ICertificacionesVolumenesService _certService;

        public CertificacionesController(ILogger<CertificacionesController> logger, ICertificacionesVolumenesService certService)
        {
            _logger = logger;
            _certService = certService;
        }

        [HttpGet]
        public async Task<ResultDto<List<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener>>> Get(int id_certificacion_volumen)
        {
            try
            {

                var rng = new Random();
                var r = await this._certService.UspWebCertificacionesVolumenesPagoDetallesObtener(id_certificacion_volumen);
                return r;
                //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                //{
                //    Date = DateTime.Now.AddDays(index),
                //    TemperatureC = rng.Next(-20, 55),
                //    Summary = Summaries[rng.Next(Summaries.Length)]
                //})
                //.ToArray();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
