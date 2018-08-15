using System;
using DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

    


        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
