using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AireAcondicionado.Persistence;

namespace AireAcondicionado.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public ClienteRepository(AireAcondicionadoDbContext _Context):base(_Context)
        {
         
        }
        
    }
}
