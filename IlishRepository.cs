using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class IlishRepository : IntIlishRepo<Ilish>
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

        IEnumerable<Ilish> IntIlishRepo<Ilish>.List => throw new NotImplementedException();

        public void Add(Ilish entity)
        {
            fishRepo.ilishList.Add(entity);
        }

        public void Delete(int index)
        {
            fishRepo.ilishList.RemoveAt(index);
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
    }
}
