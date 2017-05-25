using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaCulminacion { get; set; }
        public DateTime fechaGarantia { get; set; }
        
        public int FormaPagoId { get; set; }
        public FormaPago FormaPago { get; set; }

        public int AlmacenId { get; set; }
        public Almacen Almacen { get; set; }

        public int CotizacionId { get; set; }
        public Cotizacion Cotizacion { get; set; }
    }
}
