using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }

        public int ComprobantePagoId { get; set; }
        public ICollection<ComprobantePago> ComprobantePagos { get; set; }

        public ICollection<Cotizacion> Cotizaciones { get; set; }

        public Cliente()
        {
            ComprobantePagos = new HashSet<ComprobantePago>();
            Cotizaciones = new Collection<Cotizacion>();
        }
    }
}
