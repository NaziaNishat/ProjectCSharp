using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

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
            else if (entity is Ilish ilish)
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
            else if(type == "ILISH")
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

        public List<T> getList<T>()
        {
            List<T> fishList;


            if (typeof(T).Equals(typeof(Rui)))
            {
            fishList = fishRepo.ruiList.Cast<T>().ToList();
            }

            else if (typeof(T).Equals(typeof(Katla)))
            {
            fishList = fishRepo.katlaList.Cast<T>().ToList();
            }
            else
            {
            fishList = fishRepo.ilishList.Cast<T>().ToList();
            } 

            return fishList; 
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
