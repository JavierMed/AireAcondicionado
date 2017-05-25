using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class FormaPagoConfiguration:EntityTypeConfiguration<FormaPago>
    {
        public FormaPagoConfiguration()
        {
            Property(v => v.tipoPago)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
