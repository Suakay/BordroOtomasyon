using BordroOtomasyon.Domain.Models.Entites;
using BordroOtomasyon.Infrastructure.Context;
using BordroOtomasyon.Infrastructure.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
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
