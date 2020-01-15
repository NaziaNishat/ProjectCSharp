using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class RuiRepository : IRepository<Rui>
    {   
        FishRepo fishRepo;
        public RuiRepository(){
            fishRepo = FishRepo.getInstance();
        }
        public IEnumerable<Rui> List
        {
            get
            {
                return fishRepo.ruiList;
            }
            
        }

        IEnumerable<Rui> IRepository<Rui>.List => throw new NotImplementedException();

        public void Add(Rui entity)
        {
            fishRepo.ruiList.Add(entity);
        }

        public void Delete(int index)
        {
            fishRepo.ruiList.RemoveAt(index);
        }

        public int Length(){
            return fishRepo.ruiList.Count;
        }

        public Rui FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Rui FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public void Update(Rui entity)
        {
            throw new NotImplementedException();
        }
    }
}
