using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class IlishRepository : IRepository<Fish>
    {
        public IEnumerable<Fish> List => throw new NotImplementedException();

        public void Add(Fish entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fish entity)
        {
            throw new NotImplementedException();
        }

        public Fish FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Fish FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public void Update(Fish entity)
        {
            throw new NotImplementedException();
        }
    }
}
