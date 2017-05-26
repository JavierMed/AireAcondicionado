using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class CargoRepository : Repository<Cargo>, ICargoRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public CargoRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
