using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ServicioConfiguration:EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            HasRequired(v => v.Cotizacion)
                .WithMany(g => g.Servicios)
                .HasForeignKey(v => v.CotizacionId);

            HasMany(v => v.Trabajadores)
                .WithMany(t => t.Servicios)
                .Map(m =>
                {
                    m.ToTable("ServicioTrabjador");
                    m.MapLeftKey("ServicioId");
                    m.MapRightKey("TrabajadorId");
                });
        }
    }
}
