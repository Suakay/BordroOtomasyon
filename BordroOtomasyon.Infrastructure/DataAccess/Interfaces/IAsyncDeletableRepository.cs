using BordroOtomasyon.Domain.Interfaces;
using BordroOtomasyon.Domain.Models.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncDeletableRepository<TEntity> where TEntity : BaseEntity
    {
        Task DeleteAsync(TEntity entity);//silme işlemi olduğundan dönme yok burda
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);
    }
}
