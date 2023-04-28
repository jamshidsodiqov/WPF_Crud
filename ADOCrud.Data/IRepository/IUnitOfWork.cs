using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Data.IRepository
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Course> Courses { get; set; }
        public IGenericRepository<Student> Students { get; set; }
        public IGenericRepository<Teacher> Teachers { get; set; }

        Task SaveChangesAsync();
    }
}
