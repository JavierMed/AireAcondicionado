using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class UbigeoRepository : Repository<Ubigeo>, IUbigeoRepository
    {
        private readonly AireAcondicionadoDbContext _Context;

        public UbigeoRepository(AireAcondicionadoDbContext _Context)
        {
            this._Context = _Context;
        }
        private UbigeoRepository()
        {

        }
    }
}
