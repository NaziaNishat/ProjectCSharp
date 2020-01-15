using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class Repository : IRepository<T> where T : Fish
    {
        public IEnumerable<T> List => throw new NotImplementedException();

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public T FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public T FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
