using System;
using DL.Entities;

namespace RL.Repositories
{
    public interface IUnitOfWork
    {
        IStudentRepository<Student> StudentRepository { get; }
        ICourseRepository<Course> CourseRepository { get; }
        void Save();
    }
}
