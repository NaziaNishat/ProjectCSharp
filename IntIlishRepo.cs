using System;
using System.Threading;
using System.Collections.Generic;
public interface IntIlishRepo<Ilish> 
    {   
        IEnumerable<Ilish> List { get; }
        void Add(Ilish entity);
        void Delete(int index);
        void Update(Ilish entity);
        Ilish FindByName(String name);
        Ilish FindByWeight(String weight);
    }