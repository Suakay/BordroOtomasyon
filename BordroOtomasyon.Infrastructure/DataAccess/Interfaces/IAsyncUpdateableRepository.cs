using BordroOtomasyon.Domain.Models.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncUpdateableRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
