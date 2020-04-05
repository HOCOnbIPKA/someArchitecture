using core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure
{
    class ElementRepository<TEntity>: IElementRepository<TEntity>  where TEntity : class
    {
        internal SomeContext context;
        internal DbSet<TEntity> dbSet;
        public ElementRepository(SomeContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void CreateElement(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void DeleteElement(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public void Dispose()
        {
            
        }
        public TEntity GetElement(object id)
        {
            return dbSet.Find(id);
        }
    }
}
