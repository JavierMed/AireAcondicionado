using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class CliEmpresa : Cliente
    {
        public int CliEmpresaId { get; set; }
        public string razonSocial { get; set; }
        public string personaContacto { get; set; }  
    }
}
