using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string numDocumento { get; set; }

        public ICollection<Contacto> Contactos  { get; set; }

        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public Persona()
        {
            Contactos = new HashSet<Contacto>();
        }

    }
}
