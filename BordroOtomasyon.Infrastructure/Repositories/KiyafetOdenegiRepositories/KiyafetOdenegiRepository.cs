using BordroOtomasyon.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MVCFinalProje.Infrastructure.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.KiyafetOdenegiRepositories
{
    public class KiyafetOdenegiRepository : EFBaseRepository<KiyafetOdenegi>, IkyafetOdeneğiRepository
    {
        public KiyafetOdenegiRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
