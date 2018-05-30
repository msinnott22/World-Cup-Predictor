using System;
using System.Data.Entity;
using System.Linq;
using Data.Interfaces;

namespace Data.Extensions
{
    public static class EntityFramework
    {
        public static void AddIfNotExists<TEntity>(this IDbSet<TEntity> set, params TEntity[] entities)
            where TEntity : class, IEntity
        {
            if (set == null)
            {
                throw new Exception("DbSet not assigned");
            }

            if (entities == null)
            {
                throw new Exception("Entities not assigned");
            }

            if (set is DbSet<TEntity> dbSet)
            {
                foreach (var entity in entities)
                {
                    if (!dbSet.Any(x => x.Id.Equals(entity.Id)))
                    {
                        dbSet.Add(entity);
                    }
                }
            }
        }
    }
}
