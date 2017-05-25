using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class ComprobantePago
    {
        public int ComprobantePagoId { get; set; }
        public string tipoComprobante { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double total { get; set; }
        public DateTime fechaPago { get; set; }


        public Cliente Cliente { get; set; }

        public int CotizacionId { get; set; }
        public ICollection<Cotizacion> Cotizacion { get; set; }

        public ComprobantePago()
        {
            Cliente = new Cliente();
            Cotizacion = new HashSet<Cotizacion>();
        }
    }
}
