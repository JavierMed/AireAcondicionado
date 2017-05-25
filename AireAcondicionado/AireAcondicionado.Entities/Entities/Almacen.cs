using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Entities.Entities
{
    public class Almacen
    {
        public int AlmacenId { get; set; }
        public string modelo { get; set; }
        public int capacidad { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public double descuento { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public List<Contrato> Contratos { get; set; }

        public Almacen()
        {
            Contratos = new List<Contrato>();
        }
    }
}
