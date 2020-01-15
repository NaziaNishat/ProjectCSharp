using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class KatlaRepository : IRepository<Katla>
    {   
        FishRepo fishRepo;
        public KatlaRepository(){
            fishRepo = FishRepo.getInstance();
        }
        public IEnumerable<Katla> List
        {
            get
            {
                return fishRepo.katlaList;
            }
            
        }

        public int Length(){
            return fishRepo.katlaList.Count;
        }

        public void Add(Katla entity)
        {
            fishRepo.katlaList.Add(entity);
        }

        public void Delete(int index)
        {
            fishRepo.katlaList.RemoveAt(index);
        }

        public void Update(Katla entity)
        {
            throw new NotImplementedException();
        }

        public Katla FindByName(string name)
        {
            // var result = (from r in fishRepo.katlaList.Katla.name where r.name == name select r).FirstOrDefault();
            // return result;
            throw new NotImplementedException();        
        }

        public Katla FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

    }
}
