using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentHatchery
{
    public interface IRepository
    {
        // IEnumerable<T> List{ get; }

        // IEnumerable<T> List();

        List<T> getList<T>();


        // IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add<T>(T entity);
        void Delete(int index, String type);
        void Update<T>(T entity);
        T FindByName<T>(String name);
        T FindByWeight<T>(String weight);
    }
}
