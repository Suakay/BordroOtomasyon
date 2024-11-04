
using BordroOtomasyon.Domain.Entities;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using MVCFinalProje.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.TediyeRepositories
{
    public interface ITediyeRepository : IAsyncRepository, IRepository, IAsyncFindable<Tediye>, IAsyncInsertable<Tediye>, IAsyncQueryableRepository<Tediye>, IAsyncDeletableRepository<Tediye>, IAsyncUpdateableRepository<Tediye>, IAsyncTransactionRepository, IAsyncOrderableRepository<Tediye>
    {
       
    }
}
