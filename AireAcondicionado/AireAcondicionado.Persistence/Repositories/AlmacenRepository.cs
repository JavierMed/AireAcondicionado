using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class AlmacenRepository : Repository<Almacen>, IAlmacenRepository
    {
        private readonly AireAcondicionadoDbContext _Context;

        public AlmacenRepository(AireAcondicionadoDbContext _Context)
        {
            this._Context = _Context;
        }
        private AlmacenRepository()
        {

        }
    }
}
