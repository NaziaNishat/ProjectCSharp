using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class KatlaRepository : IRepository<Fish>
    {   
        IEnumerable<Fish> IRepository<Fish>.List => throw new NotImplementedException();

        Katla katla;

        public KatlaRepository(){
            katla = new Katla();
        }

        // public IEnumerable<Katla> List
        // {
        //     get
        //     {

        //     }
            
        // }

        public void Add(Fish entity)
        {
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
