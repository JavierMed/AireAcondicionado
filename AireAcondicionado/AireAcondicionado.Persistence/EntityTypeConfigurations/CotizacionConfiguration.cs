using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class CotizacionConfiguration:EntityTypeConfiguration<Cotizacion>
    {
        public CotizacionConfiguration()
        {
            Property(v => v.fechaVisita)
                .IsRequired()
                .HasColumnType("DateTime");

            Property(v => v.tipoServicio)
                .IsRequired()
                .HasMaxLength(150);

            Property(v => v.componente)
                .IsRequired()
                .HasMaxLength(150);

            Property(v => v.caracteristica)
                .IsRequired()
                .HasMaxLength(150);

            Property(v => v.costo)
                .IsRequired()
                .HasColumnType("double");

            HasRequired(v => v.Trabajador)
                .WithMany(g => g.Cotizaciones)
                .HasForeignKey(v => v.TrabajadorId);

            HasRequired(v => v.Cliente)
                .WithMany(g => g.Cotizaciones)
                .HasForeignKey(v => v.ClienteId);

        }
    }
}
