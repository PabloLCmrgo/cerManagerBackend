using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationManager.Shared.Models.Filter
{
    public class DespachoGasolineroDto
    {
        public int CodCli { get; set; }
        public int CodUsuario { get; set; }
        public int Producto { get; set; }
        public int Estacion { get; set; }
        public string Grupo { get; set; }
        public int Vehiculo { get; set; }
        public int Presupuestal { get; set; }
        public int Patrimonial { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int KmConsumo { get; set; }
    }
}
