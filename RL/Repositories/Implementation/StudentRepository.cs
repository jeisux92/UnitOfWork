using System;
using System.Collections.Generic;
using DL.Entities;
using System.Linq;
using DL.Context;

namespace RL.Repositories.Implementation
{
    public class StudentRepository<T> : IStudentRepository<Student>
    {
        private SchoolContext schoolContext;
        public StudentRepository(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }


        public void Add(Student item) => this.schoolContext.Students.Add(item);



        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Student item)
        {
            throw new NotImplementedException();
        }

    }
}
