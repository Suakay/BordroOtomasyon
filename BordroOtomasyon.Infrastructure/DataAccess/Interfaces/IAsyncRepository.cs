using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncRepository
    {
        Task<int> SaveChangesAsync();

    }
}
