using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public DateTime fechaInicioSer { get; set; }
        public DateTime fechaFinSer { get; set; }

        public ICollection<Trabajador> Trabajadores { get; set; }

        public int CotizacionId { get; set; }
        public Cotizacion Cotizacion { get; set; }

        public Servicio()
        {
            Trabajadores = new Collection<Trabajador>();
        }
    }
}
