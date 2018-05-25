using System;
using System.Linq;

namespace Data.Interfaces
{
    public interface IWriteStoreDataContext
    {
        IQueryable<T> Query<T>() where T : class, IEntity;
        T Load<T>(Guid id) where T : class, IEntity;
        void Insert<T>(T item) where T : class, IEntity;
        void Delete<T>(T item) where T : class, IEntity;
        int SaveChanges();
    }
}