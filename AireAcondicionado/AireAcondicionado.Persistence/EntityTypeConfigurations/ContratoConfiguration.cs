using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ContratoConfiguration:EntityTypeConfiguration<Contrato>
    {
        public ContratoConfiguration()
        {
            Property(v => v.fechaInicio)
                .IsRequired()
                .HasColumnType("DateTime");

            Property(v => v.fechaCulminacion)
                .IsRequired()
                .HasColumnType("DateTime");

            Property(v => v.fechaGarantia)
                .IsRequired()
                .HasColumnType("DateTime");

            HasRequired(v => v.Almacen)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.AlmacenId);

            HasRequired(v => v.FormaPago)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.FormaPagoId);

            HasRequired(v => v.Cotizacion)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.CotizacionId);
        }
    }
}
