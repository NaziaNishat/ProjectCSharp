using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentHatchery
{
    public interface IRepository<T> where T : Fish
    {   
        // IEnumerable<T> List { get; }

        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(int index,String type);
        void Update(T entity);
        T FindByName(String name);
        T FindByWeight(String weight);
    }
}
