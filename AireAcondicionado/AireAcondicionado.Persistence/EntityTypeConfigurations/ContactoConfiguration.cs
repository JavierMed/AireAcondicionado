﻿using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ContactoConfiguration:EntityTypeConfiguration<Contacto>
    {
        public ContactoConfiguration()
        {
            Property(v => v.contacto)
               .IsRequired()
               .HasMaxLength(200);
        }
    }
}
