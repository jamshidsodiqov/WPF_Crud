using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Teachers;
using ADOCrud.Service.DTOs.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.Interfaces
{
    public interface ITeacherService
    {
        ValueTask<IEnumerable<TeacherForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Teacher, bool>> expression = null);
        ValueTask<TeacherForViewDTO> GetAsync(Expression<Func<Teacher, bool>> expression);
        ValueTask<TeacherForViewDTO> CreateAsync(TeacherForCreationDTO TeacherForCreationDTO);
        ValueTask<bool> DeleteAsync(int id);
        ValueTask<TeacherForViewDTO> UpdateAsync(int id, TeacherForUpdateDTO TeacherForUpdateDTO);
    }
}
