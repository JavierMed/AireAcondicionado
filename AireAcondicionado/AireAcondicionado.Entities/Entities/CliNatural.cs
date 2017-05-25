using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class CliNatural : Cliente
    {
        public int CliNaturalId { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }

        
    }
}
