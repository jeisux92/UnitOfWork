using System;
using System.Collections.Generic;

namespace RL.Repositories
{
    public interface IBaseRepository<T> 
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
