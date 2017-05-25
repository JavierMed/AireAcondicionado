using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string nomCargo { get; set; }

        public ICollection<Trabajador> Trabajadores { get; set; }

        public Cargo()
        {
            Trabajadores = new HashSet<Trabajador>();
        }
    }
}
