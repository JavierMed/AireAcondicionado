﻿using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ProvinciaConfiguration:EntityTypeConfiguration<Provincia>
    {
        public ProvinciaConfiguration()
        {
            Property(v => v.nomProvincia)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
