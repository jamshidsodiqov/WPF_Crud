using ADOCrud.Data.DbContexts;
using ADOCrud.Data.IRepository;
using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public IGenericRepository<Course> Courses { get; set; }
        public IGenericRepository<Student> Students { get; set; }
        public IGenericRepository<Teacher> Teachers { get; set; }

        public UnitOfWork()
        {
            dbContext = new AppDbContext();
            Courses = new GenericRepository<Course>();
            Students = new GenericRepository<Student>();
            Teachers = new GenericRepository<Teacher>();
        }


        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}
