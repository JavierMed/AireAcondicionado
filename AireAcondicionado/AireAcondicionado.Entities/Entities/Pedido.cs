using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int CompraId { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
        public double descuento { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public int FormaPagoId { get; set; }
        public FormaPago FormaPago { get; set; }
    }
}
