
using BordroOtomasyon.Domain.Entities;
using BordroOtomasyon.Infrastructure.Context;

using Microsoft.EntityFrameworkCore;
using MVCFinalProje.Infrastructure.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.TediyeRepositories
{
    public class TediyeRepository : EFBaseRepository<Tediye>, ITediyeRepository
    {
      public TediyeRepository(AppDbContext context): base(context) { }   
    }
}
