using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TGProyectoG.Business.Interfaces;

namespace TGProyectoG.Business
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T>
        where T : class
        where C : DbContext, new()
    {
        private C entities = new C();

        public C Context
        {
            get { return this.entities; }
            set { this.entities = value; }
        }


        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = this.entities.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = this.entities.Set<T>().Where(predicate);
            return query;
        }


        public virtual void Add(T entity)
        {
            this.entities.Set<T>().Add(entity);
        }

        public virtual void Attach(T entity)
        {
            this.entities.Set<T>().Attach(entity);
        }

        public virtual void Delete(T entity)
        {
            this.entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            this.entities.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public virtual void Save()
        {
            this.entities.SaveChanges();
        }
    }
}
