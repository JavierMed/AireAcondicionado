using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class ContratoRepository : Repository<Contrato>, IContratoRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public ContratoRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
