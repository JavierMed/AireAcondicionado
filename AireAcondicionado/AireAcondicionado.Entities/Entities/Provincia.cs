using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string nomProvincia { get; set; }

        public ICollection<Ubigeo> Ubigeos { get; set; }

        public Provincia()
        {
            Ubigeos = new HashSet<Ubigeo>();
        }
    }
}
