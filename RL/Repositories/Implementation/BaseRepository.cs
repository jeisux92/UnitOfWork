using System;
using DL.Context;
using RL.Repositories;

namespace RL.Repositories.Implementation
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
    {
        protected SchoolContext schoolContext;
        public BaseRepository(SchoolContext schoolContext)
        {

            this.schoolContext = schoolContext;
        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }


}
