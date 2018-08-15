using System;
using DL.Entities;
using RL.Repositories;

namespace Service.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Student GetUser(int id)
        {
            return this.unitOfWork.StudentRepository.GetById(id);
        }

        public void SaveUser(Student student)
        {
            this.unitOfWork.StudentRepository.Add(student);
            this.unitOfWork.Save();
        }
    }
}
