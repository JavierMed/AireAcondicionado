using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Trabajador : Persona
    {
        public double sueldo { get; set; }
        public double bono { get; set; } 

        public ICollection<Cotizacion> Cotizaciones { get; set; }

        public ICollection<Servicio> Servicios { get; set; }

        public Cargo Cargo { get; set; }

        public Trabajador()
        {
            Cotizaciones = new Collection<Cotizacion>();
            Servicios = new Collection<Servicio>();
        }

        

    }
}
