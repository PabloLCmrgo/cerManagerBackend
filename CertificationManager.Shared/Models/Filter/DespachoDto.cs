using System;

namespace CertificationManager.Shared.Models.Filter
{
    public class DespachoDto
    {
        public int CodCli { get; set; }
        public int GasDde { get; set; }
        public string Grp { get; set; }
        public int TarDde { get; set; }
        public int Prd { get; set; }
        public int CtaPre { get; set; }
        public int NroPat { get; set; }
        public DateTime FchDde { get; set; }
        public DateTime FchHta { get; set; }
        public int KmConsumo { get; set; }
        public string rangoFechas { get; set; }
    }
}
