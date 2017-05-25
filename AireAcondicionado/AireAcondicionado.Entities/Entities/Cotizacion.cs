using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Cotizacion
    {
        public int CotizacionId { get; set; }
        public DateTime fechaVisita { get; set; }
        public string tipoServicio { get; set; }
        public string componente { get; set; }
        public string caracteristica { get; set; }
        public double costo { get; set; }

        public int ComprobantePagoId { get; set; }
        public ComprobantePago ComprobantePago { get; set; }

        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<Servicio> Servicios { get; set; }

        public List<Contrato> Contratos { get; set; }

        public Cotizacion()
        {
            Servicios = new List<Servicio>();
            Contratos = new List<Contrato>();
        }

    }
}
