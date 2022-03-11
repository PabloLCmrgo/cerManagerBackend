using System;

namespace CertificationManager.Shared.Models.Filter
{
    public class VehiculoSelectDto
    {
        public int CodCli { get; set; }
        public DateTime FchDde { get; set; }
        public DateTime FchHta { get; set; }
        public string CodGrp { get; set; }
        public int NroVeh { get; set; }
        public int KmConsumo { get; set; }
    }
}
