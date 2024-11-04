
using BordroOtomasyon.Domain.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.DataAccess.Interfaces
{
    public interface IAsyncFindable<TEntity> where TEntity : BaseEntity
    {
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null); //ikinci kısımda expression parametresi verilmezse default olarak null gelsin demek o ifade
        Task<TEntity?> GetByIdAsync(Guid id, bool tracking = true); //bir parametre göndermezsem bunu true al çünkü track kullanılan bir şey kolaylık olsun diye track edilmesi istenmeyen bir şey için gelip false yazarsın
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true); //track ediliyo mu mevzusu aynı expression mevzusu da aynı fakat dönüşü var bi TEntity 1:06 performans problemi kısmını dinle bida
    }
}
