using System;
using System.Collections.Generic;
using DL.Context;
using DL.Entities;

namespace RL.Repositories.Implementation
{
    public class CourseRepository<T> : BaseRepository<Course>, ICourseRepository<Course>
    {
       

        public CourseRepository(SchoolContext schoolContext) : base(schoolContext)
        {
        }

        public void Add(Course item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            string s = string.Empty;
            return null;
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course item)
        {
            throw new NotImplementedException();
        }
    }


}
