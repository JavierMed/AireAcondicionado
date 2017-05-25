using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ComprobantePagoConfiguration:EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            Property(v => v.tipoComprobante)
               .IsRequired()
               .HasMaxLength(150);

            Property(v => v.cantidad)
                .IsRequired()
                .HasColumnType("int");

            Property(v => v.descripcion)
               .IsRequired()
               .HasMaxLength(150);

            Property(v => v.total)
                .IsRequired()
                .HasColumnType("double");

            Property(v => v.fechaPago)
                .IsRequired()
                .HasColumnType("DateTime");

            HasRequired(v => v.Cliente)
                .WithMany(g => g.ComprobantePagos)
                .HasForeignKey(v => v.ClienteId);
        }
    }
}
