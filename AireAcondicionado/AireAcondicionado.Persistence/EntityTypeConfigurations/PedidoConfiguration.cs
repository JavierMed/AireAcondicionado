using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class PedidoConfiguration:EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasRequired(v => v.Proveedor)
                .WithMany(g => g.Pedidos)
                .HasForeignKey(v => v.ProveedorId);

            HasMany(v=>v.cantidad).WithMany().
        }
    }
}
