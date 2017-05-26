using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class ComprobantePagoRepository : Repository<ComprobantePago>, IComprobantePagoRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public ComprobantePagoRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
