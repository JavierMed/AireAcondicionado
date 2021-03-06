﻿using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence.Repositories
{
    public class CliNaturalRepository : Repository<CliNatural>, ICliNaturalRepository
    {
        //private readonly AireAcondicionadoDbContext _Context;

        public CliNaturalRepository(AireAcondicionadoDbContext _Context) : base(_Context)
        {
        }
    }
}
