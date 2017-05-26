using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class DocumentoRepository : Repository<Documento>, IDocumentoRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public DocumentoRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
