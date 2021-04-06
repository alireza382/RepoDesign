using Microsoft.EntityFrameworkCore;
using RepoDesign.dataRepo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDesign.dataRepo.Repository
{

    class DataRepository<T> : IDataRepository<T> where T :class
    {

        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _dbset;

        public DataRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbset = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public T Get(int id)
        {
           return  _dbset.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includePeroperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFristOrDefault(Expression<Func<T, bool>> filter = null, string includePeroperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int i)
        {
            T entity = _dbset.Find(i);
            if (entity == null) return;
            Remove(entity);
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }
    }
}
