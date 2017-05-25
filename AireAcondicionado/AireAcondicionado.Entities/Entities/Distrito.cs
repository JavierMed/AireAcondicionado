using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public string nomDistrito { get; set; }

        public ICollection<Ubigeo> Ubigeos { get; set; }

        public Distrito()
        {
            Ubigeos = new HashSet<Ubigeo>();
        }
    }
}
