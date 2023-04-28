using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Service.DTOs.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.Interfaces
{
    public interface IStudentService
    {
        ValueTask<IEnumerable<StudentForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Student, bool>> expression = null);
        ValueTask<StudentForViewDTO> GetAsync(Expression<Func<Student, bool>> expression);
        ValueTask<StudentForViewDTO> CreateAsync(StudentForCreationDTO StudentForCreationDTO);
        ValueTask<bool> DeleteAsync(int id);
        ValueTask<StudentForViewDTO> UpdateAsync(int id, StudentForUpdateDTO StudentForUpdateDTO);
    }
}
