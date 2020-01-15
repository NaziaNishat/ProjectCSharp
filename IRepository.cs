using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    public interface IRepository<T> where T : Fish
    {   
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(int index);
        void Update(T entity);
        T FindByName(String name);
        T FindByWeight(String weight);
    }
}
