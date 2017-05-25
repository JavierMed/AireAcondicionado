using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class PersonaConfiguration:EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            ToTable("Persona");
            HasKey(p => p.PersonaId);
            Property(p => p.nombre).IsRequired();
            Property(p => p.direccion).IsRequired();
            Property(p => p.numDocumento).IsRequired();

            Map<Trabajador>(m => m.Requires("Discriminador").HasValue("Trabajador"));
            Map<Cliente>(m => m.Requires("Discriminador").HasValue("Cliente"));

            HasRequired(v => v.Documento)
                .WithMany(g => g.Personas)
                .HasForeignKey(v => v.DocumentoId);

            HasRequired(v => v.Ubigeo)
                .WithMany(g => g.Personas)
                .HasForeignKey(v => v.UbigeoId);

            HasMany(v => v.Contactos)
                .WithMany(t => t.Personas)
                .Map(m =>
                {
                    m.ToTable("PersonaContacto");
                    m.MapLeftKey("PersonaId");
                    m.MapRightKey("ContactoId");
                });

        }
    }
}
