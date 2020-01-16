using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentHatchery
{
    public class Repository<T> : IRepository<T> where T : Fish
    {
        FishRepo fishRepo;

        public Repository()
        {
            fishRepo = FishRepo.getInstance();
        }

        public IEnumerable<T> List => throw new NotImplementedException();

        public void Add(T entity)
        {
            //    if (typeof(T) == typeof(CarWheel))

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

        public void Delete(int index, String type)
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

        public int LengthOfList(String type)
        {
            if (type == "RUI")
            {
                return fishRepo.ruiList.Count;

            }
            else if (type == "KATLA")
            {
                return fishRepo.katlaList.Count;

            }
            else
            {
                return fishRepo.ilishList.Count;

            }
        }

        public T FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public T FindByWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.List()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
