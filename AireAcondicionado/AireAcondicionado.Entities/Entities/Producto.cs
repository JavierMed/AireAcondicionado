using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string nomProducto { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public List<Almacen> Almacenes { get; set; }

        public Producto()
        {
            Pedidos = new List<Pedido>();
            Almacenes = new List<Almacen>();
        }


    }
}
