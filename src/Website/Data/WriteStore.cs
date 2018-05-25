using System;
using System.Linq;
using Data.Interfaces;

namespace Data
{
    public class WriteStore : IWriteStore
    {
        private readonly IWriteStoreDataContext _dataContext;

        public WriteStore(IWriteStoreDataContext dataContext)
        {

            _dataContext = dataContext;
        }

        public IQueryable<T> Query<T>() where T : class, IEntity
        {
            return _dataContext.Query<T>();
        }

        public T Load<T>(Guid id) where T : class, IEntity
        {
            return _dataContext.Load<T>(id);
        }

        public void Insert<T>(T item) where T : class, IEntity
        {
            _dataContext.Insert(item);
        }

        public void Delete<T>(T item) where T : class, IEntity
        {
            _dataContext.Delete(item);
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }
    }
}