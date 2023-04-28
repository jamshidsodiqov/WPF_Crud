using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Service.DTOs.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.Interfaces
{
    public interface ICourseService
    {
        ValueTask<IEnumerable<CourseForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Course, bool>> expression = null);
        ValueTask<CourseForViewDTO> GetAsync(Expression<Func<Course, bool>> expression);
        ValueTask<CourseForViewDTO> CreateAsync(CourseForCreationDTO CourseForCreationDTO);
        ValueTask<bool> DeleteAsync(int id);
        ValueTask<CourseForViewDTO> UpdateAsync(int id, CourseForUpdateDTO CourseForUpdateDTO);
    }
}
