using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        public string tipoDocumento { get; set; }

        public ICollection<Persona> Personas { get; set; }

        public Documento()
        {
            Personas = new HashSet<Persona>();
        }
    }
}
