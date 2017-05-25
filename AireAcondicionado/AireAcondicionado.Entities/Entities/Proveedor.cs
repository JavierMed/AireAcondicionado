using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string nomProveedor { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public Proveedor()
        {
            Pedidos = new HashSet<Pedido>();
        }
    }
}
