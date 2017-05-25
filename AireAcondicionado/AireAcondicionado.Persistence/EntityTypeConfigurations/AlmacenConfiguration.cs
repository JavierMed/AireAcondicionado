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

            HasRequired(v => v.Producto)
                .WithMany(g => g.Almacenes)
                .HasForeignKey(v => v.ProductoId);
        }
    }
}
