using System;

namespace CertificationManager.Core.Abstractions.Dtos
{
    public class ClientesDto
    {
        public int cod { get; set; }
        public string den { get; set; }
        public string dom { get; set; }
        public string col { get; set; }
        public string del { get; set; }
        public string ciu { get; set; }
        public string est { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string rfc { get; set; }
        public byte? tipval { get; set; }
        public double? mtoasg { get; set; }
        public double? mtodis { get; set; }
        public double? mtorep { get; set; }
        public short? cndpag { get; set; }
        public short? diarev { get; set; }
        public string horrev { get; set; }
        public short? diapag { get; set; }
        public string horpag { get; set; }
        public string cto { get; set; }
        public string obs { get; set; }
        public string codext { get; set; }
        public int? datcon { get; set; }
        public string codpos { get; set; }
        public byte? pto { get; set; }
        public double? ptosdo { get; set; }
        public double? debsdo { get; set; }
        public double? cresdo { get; set; }
        public int? fmtexp { get; set; }
        public string arcexp { get; set; }

    }
}
