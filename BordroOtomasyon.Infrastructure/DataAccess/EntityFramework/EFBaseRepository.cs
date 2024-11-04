using BordroOtomasyon.Domain.Core.BaseEntities;
using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using MVCFinalProje.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCFinalProje.Infrastructure.DataAccess.EntityFramework
{
    public class EFBaseRepository<TEntity> : IRepository, IAsyncRepository, IAsyncInsertable<TEntity>, IAsyncUpdateableRepository<TEntity>, IAsyncDeletableRepository<TEntity>, IAsyncFindable<TEntity>, IAsyncQueryableRepository<TEntity>, IAsyncOrderableRepository<TEntity>, IAsyncTransactionRepository where TEntity : BaseEntity
    {
        protected readonly DbContext _dbContext; //kalıtım alan yerler de şaapsın

        protected readonly DbSet<TEntity> _table;

        public EFBaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            //_dbContext.Set<TEntity>().Add(entity);
            var entry = await _table.AddAsync(entity);
            return entry.Entity;
            // Attempting to directly access the entity without awaiting won't work
            // var task = _table.AddAsync(entity);
            // task.Entity does not exist, because task is of type Task<EntityEntry<TEntity>>

            // You need to await the task to get the result
            //var entry = await task; // Now entry is of type EntityEntry<TEntity>
            // var addedEntity = entry.Entity; // Now you can access the added entity
            // return addedEntity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities); //async method kullanıyorsan bir bodyde await yazman lazım o satırda ( aynı bodyde sync olanlar için gerek yok manasına gelir )ve eğer o body bir methodun parçasıysa o methodu da async olarak tanımlaman gerekiyor
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression is null ? await GetAllActives().AnyAsync() : await GetAllActives().AnyAsync(expression); //kosul nullable ise parametrenin içine ? koyarak yapamazsın ternary if lazıms
        }
        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true)
        {
            return await GetAllActives(tracking).FirstOrDefaultAsync(expression);
        }

        public async Task<TEntity?> GetByIdAsync(Guid id, bool tracking = true)
        {
            return await GetAllActives(tracking).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.FromResult(_table.Remove(entity));
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            //await Task.FromResult(_table.RemoveRange(entities));
            //remove range void döndüğü için fromresult işe yaramadı

            //_table.RemoveRange(entities); // Perform the synchronous remove operation
            //await Task.CompletedTask; // Return a completed task bu sanırım fakelemek oluyo

            _table.RemoveRange(entities); // Remove the entities
            await _dbContext.SaveChangesAsync(); // Save changes to the database
            //bu async prensiplerine uygun ama çatırt diye savelediği için bi tehlike arz ediyor bence bencesi bu
        }



        public int SaveChange()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {

            return await Task.FromResult(_table.Update(entity).Entity);
        }

        protected IQueryable<TEntity> GetAllActives(bool tracking = true)
        {
            var values = _table.Where(o => o.Status != Status.Deleted);
            return tracking ? values : values.AsNoTracking();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = true)
        {
            return await GetAllActives(tracking).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true)
        {
            return await GetAllActives(tracking).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool orderByDescending, bool tracking = true)
        {
            return orderByDescending ? await GetAllActives(tracking).OrderByDescending(orderBy).ToListAsync() : await GetAllActives(tracking).OrderBy(orderBy).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, TKey>> orderBy, bool orderByDescending, bool tracking = true)
        {
            //return orderByDescending ? await GetAllActives(tracking).Where(expression).OrderByDescending(orderBy).ToListAsync() : await GetAllActives(tracking).Where(expression).OrderBy(orderBy).ToListAsync();
            var values = GetAllActives(tracking).Where(expression);
            return orderByDescending ? await values.OrderByDescending(orderBy).ToListAsync() : await values.OrderBy(orderBy).ToListAsync();
        }

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }//rollbackler için

        public Task<IExecutionStrategy> CreateExecutionStrategy()
        {
            return Task.FromResult(_dbContext.Database.CreateExecutionStrategy());
        }//rollbackler üçün

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        //falan

        //protected IQueryable<TEntity> GetAllSoftDeleted(bool tracking = true)
        //{
        //    var values = _table.Where(o => o.Status == Status.Deleted);
        //    return tracking ? values : values.AsNoTracking();
        //}

    }
}
