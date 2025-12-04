using Microsoft.EntityFrameworkCore;
using MyWallet.Domain.Base;
using MyWallet.Repository.Context;

namespace MyWallet.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected MyWalletContext _mysSqlContext;

        public BaseRepository(MyWalletContext mySqlContext)
        {
            _mysSqlContext = mySqlContext;
        }
        
        public void AttachObject(object obj)
        {
            _mysSqlContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mysSqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _mysSqlContext.Set<TEntity>().Add(obj);
            _mysSqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _mysSqlContext.Entry(obj).State = EntityState.Modified;
            _mysSqlContext.SaveChanges();
        }
        public void Delete(object id)
        {
            _mysSqlContext.Set<TEntity>().Remove(Select(id)!);
            _mysSqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity? Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }

        
    }
    
}
