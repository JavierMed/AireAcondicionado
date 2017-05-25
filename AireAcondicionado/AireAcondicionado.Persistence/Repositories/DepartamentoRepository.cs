using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository
    {
        private readonly AireAcondicionadoDbContext _Context;

        public DepartamentoRepository(AireAcondicionadoDbContext _Context)
        {
            this._Context = _Context;
        }
        private DepartamentoRepository()
        {

        }
    }
}
