using System;

namespace CertificationManager.Infrastructure.Abstractions.Entities.SPs
{

    public class ResponseUspWebPeriodosObtener
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string descripcion_detalle { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int periodo { get; set; }
        public int id_estado { get; set; }
        public string observaciones { get; set; }
        public bool activo { get; set; }
        public string estado { get; set; }
        public int id_usuario_registro { get; set; }
        public DateTime fecha_registro { get; set; }
        public string usuario_registro { get; set; }
    }
}
