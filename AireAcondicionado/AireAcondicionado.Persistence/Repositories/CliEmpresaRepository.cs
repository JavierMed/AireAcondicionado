using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class CliEmpresaRepository : Repository<CliEmpresa>, ICliEmpresaRepository
    {
        private readonly AireAcondicionadoDbContext _Context;

        public CliEmpresaRepository(AireAcondicionadoDbContext _Context)
        {
            this._Context = _Context;
        }
        private CliEmpresaRepository()
        {

        }
    }
}
