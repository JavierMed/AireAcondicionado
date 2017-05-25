using AireAcondicionado.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class AlmacenConfiguration:EntityTypeConfiguration<Almacen>
    {
        public AlmacenConfiguration()
        {
            Property(v => v.modelo)
                .IsRequired()
                .HasMaxLength(100);

            Property(v => v.capacidad)
                .IsRequired()
                .HasColumnType("int");

            Property(v => v.cantidad)
                .IsRequired()
                .HasColumnType("int");

            Property(v => v.precioCompra)
                .IsRequired()
                .HasColumnType("double");

            Property(v => v.precioVenta)
                .IsRequired()
                .HasColumnType("double");

            Property(v => v.descuento)
                .IsRequired()
                .HasColumnType("double");

            HasRequired(v => v.Producto)
                .WithMany(g => g.Almacenes)
                .HasForeignKey(v => v.ProductoId);
        }
    }
}
