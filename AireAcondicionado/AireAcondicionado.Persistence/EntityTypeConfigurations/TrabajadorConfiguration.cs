using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class TrabajadorConfiguration:EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorConfiguration()
        {
            Property(v => v.sueldo)
               .IsRequired()
               .HasColumnType("double");

            Property(v => v.bono)
               .IsRequired()
               .HasColumnType("double");

            HasRequired(v => v.Cargo)
                .WithMany(g => g.Trabajadores)
                .HasForeignKey(v => v.CargoId);


        }
    }
}
