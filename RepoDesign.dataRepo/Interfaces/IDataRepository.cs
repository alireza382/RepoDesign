
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDesign.dataRepo.Interfaces
{
    public interface IDataRepository<T>  where T : class 
    {

        T Get(int id);


        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> filter =null,
            Func<IQueryable<T>,IOrderedQueryable<T>>  orderby = null,
            string includePeroperties = null
            );

        T GetFristOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includePeroperties = null
            );

        void Add(T enitity);

        void Remove(int i);

        void Remove(T entity);
        

    }
}
