﻿using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class FormaPagoRepository : Repository<FormaPago>, IFormaPagoRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public FormaPagoRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
