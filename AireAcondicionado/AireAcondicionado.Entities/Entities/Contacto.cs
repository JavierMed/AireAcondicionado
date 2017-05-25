using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string contacto { get; set; }

        public ICollection<Persona> Personas { get; set; }

        public Contacto()
        {
            Personas = new HashSet<Persona>();
        }
    }
}
