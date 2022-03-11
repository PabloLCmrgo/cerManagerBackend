using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationManager.Shared.Models.Filter
{
    public class DetalleVehiculoNetDto
    {
        public string Tarjeta { get; set; }
        public string Descripcion { get; set; }
        public string Grupo { get; set; }
        public string Estado { get; set; }
        public string Placas { get; set; }
        public string CodCli { get; set; }
    }
}
