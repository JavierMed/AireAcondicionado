using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class FormaPago
    {
        public int FormaPagoId { get; set; }
        public string tipoPago { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public List<Contrato> Contratos { get; set; }

        public FormaPago()
        {
            Pedidos = new List<Pedido>();
            Contratos = new List<Contrato>();
        }
    }
}
