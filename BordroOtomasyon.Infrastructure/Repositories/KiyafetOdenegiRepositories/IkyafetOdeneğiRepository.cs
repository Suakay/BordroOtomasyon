using BordroOtomasyon.Domain.Entities;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using MVCFinalProje.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.KiyafetOdenegiRepositories
{
    public interface  IkyafetOdeneğiRepository: IAsyncRepository, IRepository, IAsyncFindable<KiyafetOdenegi>, IAsyncInsertable<KiyafetOdenegi>, IAsyncQueryableRepository<KiyafetOdenegi>, IAsyncDeletableRepository<KiyafetOdenegi>, IAsyncUpdateableRepository<KiyafetOdenegi>, IAsyncTransactionRepository, IAsyncOrderableRepository<KiyafetOdenegi>
    {
    }
}
