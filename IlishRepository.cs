using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentHatchery
{
    class IlishRepository : IRepository<Ilish>
    {   
        FishRepo fishRepo;
        public IlishRepository(){
            fishRepo = FishRepo.getInstance();
        }
        public IEnumerable<Katla> List
        {
            get
            {
                return fishRepo.katlaList;
            }
            
        }


        public void Add(Ilish entity)
        {
            fishRepo.ilishList.Add(entity);
        }

        public void Delete(int index)
        {
            fishRepo.ilishList.RemoveAt(index);
        }

        public void Delete(int index, string type)
        {
            throw new NotImplementedException();
        }

        public Ilish FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Ilish FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public int Length(){
            return fishRepo.ilishList.Count;
        }

        public void Update(Ilish entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ilish> IRepository<Ilish>.List()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ilish> IRepository<Ilish>.List(Expression<Func<Ilish, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
