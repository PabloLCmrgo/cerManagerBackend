using System;

namespace CertificationManager.Infrastructure.Abstractions.Entities.SPs
{

    public class ResponseUspWebCertificacionesVolumenesPagoDetallesObtener
    {
        public int id { get; set; }
        public int id_periodo { get; set; }
        public string periodo { get; set; }
        public Int64 codigo_contrato_marco { get; set; }
        public string contrato_marco { get; set; }
        public int id_posicion { get; set; }
        public int id_subposicion { get; set; }
        public int id_imputaicon { get; set; }
        public string codigo_imputacion { get; set; }
        public string imputacion { get; set; }
        public int id_tipo_imputacion { get; set; }
        public string codigo_tipo_imputacion { get; set; }
        public string tipo_imputacion { get; set; }
        public int id_voz_gasto { get; set; }
        public string codigo_voz_gasto { get; set; }
        public string voz_gasto { get; set; }
        public decimal cantidad_volumen { get; set; }
        public string observacion { get; set; }
    }
}
