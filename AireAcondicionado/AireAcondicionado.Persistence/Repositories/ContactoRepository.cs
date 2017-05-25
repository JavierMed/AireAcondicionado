using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class ContactoRepository : Repository<Contacto>, IContactoRepository
    {
        private readonly AireAcondicionadoDbContext _Context;

        public ContactoRepository(AireAcondicionadoDbContext _Context)
        {
            this._Context = _Context;
        }
        private ContactoRepository()
        {

        }
    }
}
