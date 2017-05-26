using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public ProveedorRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
