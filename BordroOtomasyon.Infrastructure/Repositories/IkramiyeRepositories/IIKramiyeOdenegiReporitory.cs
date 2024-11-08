﻿using BordroOtomasyon.Domain.Entities;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using MVCFinalProje.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.IkramiyeRepositories
{
    public interface  IIKramiyeOdenegiReporitory: IAsyncRepository, IRepository, IAsyncFindable<Ikramiye>, IAsyncInsertable<Ikramiye>, IAsyncQueryableRepository<Ikramiye>, IAsyncDeletableRepository<Ikramiye>, IAsyncUpdateableRepository<Ikramiye>, IAsyncTransactionRepository, IAsyncOrderableRepository<Ikramiye>
    {
    }
}