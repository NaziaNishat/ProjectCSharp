using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentHatchery
{
    public class Repository : IRepository
    {
        FishRepo fishRepo;
        public Repository()
        {
            fishRepo = FishRepo.getInstance();
        }
        public void Add<T>(T entity)
        {
            if (entity is Rui rui)
            {
                fishRepo.ruiList.Add((Rui)(object)entity);
            }

            else if (entity is Katla katla)
            {
                fishRepo.katlaList.Add((Katla)(object)entity);
            }
            else
            {
                fishRepo.ilishList.Add((Ilish)(object)entity);
            }
        }

        public void Delete(int index, string type)
        {
            if (type == "RUI")
            {
                fishRepo.ruiList.RemoveAt(index);
            }

            else if (type == "KATLA")
            {
                fishRepo.katlaList.RemoveAt(index);
            }
            else
            {
                fishRepo.ilishList.RemoveAt(index);
            }

        }

        public T FindByName<T>(string name)
        {
            throw new NotImplementedException();
        }

        public T FindByWeight<T>(string weight)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
