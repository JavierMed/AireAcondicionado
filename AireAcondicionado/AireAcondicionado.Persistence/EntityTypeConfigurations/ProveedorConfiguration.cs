using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ProveedorConfiguration:EntityTypeConfiguration<Proveedor>
    {
        public ProveedorConfiguration()
        {
            Property(v => v.nomProveedor)
                .IsRequired()
                .HasMaxLength(150);


            Property(v => v.direccion)
                .IsRequired()
                .HasMaxLength(150);


            Property(v => v.telefono)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
