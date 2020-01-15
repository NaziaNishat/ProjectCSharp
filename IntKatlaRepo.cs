using System;
using System.Threading;
using System.Collections.Generic;
public interface IntIKatlaRepo<Katla> 
    {   
        IEnumerable<Katla> List { get; }
        void Add(Katla entity);
        void Delete(int index);
        void Update(Katla entity);
        Katla FindByName(String name);
        Katla FindByWeight(String weight);
    }