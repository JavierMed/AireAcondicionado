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
            Property(v => v.cantidad)
                .IsRequired()
                .HasColumnType("int");

            Property(v => v.precioCompra)
                .IsRequired()
                .HasColumnType("double");

            Property(v => v.descuento)
                .IsRequired()
                .HasColumnType("double");

            HasRequired(v => v.Proveedor)
                .WithMany(g => g.Pedidos)
                .HasForeignKey(v => v.ProveedorId);

            HasRequired(v => v.Producto)
                .WithMany(g => g.Pedidos)
                .HasForeignKey(v => v.ProductoId);

            HasRequired(v => v.FormaPago)
                .WithMany(g => g.Pedidos)
                .HasForeignKey(v => v.FormaPagoId);

        }
    }
}
