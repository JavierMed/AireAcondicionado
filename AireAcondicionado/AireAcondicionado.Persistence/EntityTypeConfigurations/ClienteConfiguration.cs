using AireAcondicionado.Entities.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.EntityTypeConfigurations
{
    public class ClienteConfiguration:EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");
            HasKey(p => p.ClienteId);

            Map<CliNatural>(m => m.Requires("Descriminador").HasValue("CliNatural"));
            Map<CliEmpresa>(m => m.Requires("Descriminador").HasValue("CliEmpresa"));
        }
    }
}
