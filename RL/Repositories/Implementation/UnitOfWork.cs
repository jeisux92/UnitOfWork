using System;
using DL.Context;
using DL.Entities;

namespace RL.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private SchoolContext schoolContext;

        public UnitOfWork(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        private StudentRepository<Student> studentRepository;
        private CourseRepository<Course> courseRepository;

        public IStudentRepository<Student> StudentRepository
        {
            get
            {

                if (this.studentRepository == null)
                {
                    this.studentRepository = new StudentRepository<Student>(this.schoolContext);
                }
                return this.studentRepository;
            }

        }
        public ICourseRepository<Course> CourseRepository
        {
            get
            {

                if (this.studentRepository == null)
                {
                    this.courseRepository = new CourseRepository<Course>(this.schoolContext);
                }
                return this.courseRepository;
            }

        }

        public void Save()
        {
            this.schoolContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            schoolContext.Dispose();
        }
    }
}
