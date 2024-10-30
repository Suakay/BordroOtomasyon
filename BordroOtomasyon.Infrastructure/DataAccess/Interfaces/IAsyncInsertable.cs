using BordroOtomasyon.Domain.Models.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFinalProje.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncInsertable<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);//dönüşüvar
        Task AddRangeAsync(IEnumerable<TEntity> entities);//dönüşüyok asenkronun voidi
    }
}
