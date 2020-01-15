using System;
using System.Threading;
using System.Collections.Generic;
public interface IntRuiRepo<Rui> 
    {   
        IEnumerable<Rui> List { get; }
        void Add(Rui entity);
        void Delete(int index);
        void Update(Rui entity);
        Rui FindByName(String name);
        Rui FindByWeight(String weight);
    }