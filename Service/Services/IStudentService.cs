using System;
using DL.Entities;

namespace Service.Services
{
    public interface IStudentService
    {
        void SaveUser(Student student);
        Student GetUser(int id);
    }
}
