using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string nomDepartamento { get; set; }

        public ICollection<Ubigeo> Ubigeos { get; set; }

        public Departamento()
        {
            Ubigeos = new HashSet<Ubigeo>();
        }
    }
}
