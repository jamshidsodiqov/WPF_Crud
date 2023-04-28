using ADOCrud.Data.IRepository;
using ADOCrud.Data.Repository;
using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Service.DTOs.Courses;
using ADOCrud.Service.Exceptions;
using ADOCrud.Service.Extensions;
using ADOCrud.Service.Interfaces;
using ADOCrud.Service.Mappers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.Services
{
    public class CourseService : ICourseService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IGenericRepository<Course> genericRepository;
        private readonly IMapper mapper;

        public CourseService()
        {
            unitOfWork = new UnitOfWork();
            genericRepository = new GenericRepository<Course>();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public async ValueTask<CourseForViewDTO> CreateAsync(CourseForCreationDTO CourseForCreationDTO)
        {
            var existcourse = await unitOfWork.Courses.GetAsync(c => c.Name == CourseForCreationDTO.Name);

            if (existcourse != null)
            {
                throw new ProjectException("This course created already");
            }

            var createdcourse = await unitOfWork.Courses.CreateAsync(mapper.Map<Course>(CourseForCreationDTO));

            await unitOfWork.SaveChangesAsync();

            return mapper.Map<CourseForViewDTO>(createdcourse);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var isDeleted = await unitOfWork.Courses.DeleteAsync(id);

            if (!isDeleted)
            {
                throw new ProjectException("Course not found");
            }

            await unitOfWork.SaveChangesAsync();

            return true;
        }

        public async ValueTask<IEnumerable<CourseForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Course, bool>> expression = null)
        {
            var courses = unitOfWork.Courses.GetAll(expression, isTracking: false); 

            return mapper.Map<IEnumerable<CourseForViewDTO>>(await courses.ToPagedList(@params).ToListAsync());
        }

        public async ValueTask<CourseForViewDTO> GetAsync(Expression<Func<Course, bool>> expression)
        {
            var course = await unitOfWork.Courses.GetAsync(expression, isTracking: false);

            if (course == null)
            {
                throw new ProjectException("User not found");
            }

            return mapper.Map<CourseForViewDTO>(course);
        }

        public async ValueTask<CourseForViewDTO> UpdateAsync(int id, CourseForUpdateDTO CourseForUpdateDTO)
        {
            var existcourse = await unitOfWork.Courses.GetAsync(c => c.Id == id);

            if (existcourse == null)
            {
                throw new ProjectException("Course not found");
            }

            var course = await unitOfWork.Courses.GetAsync(s => s.Name == CourseForUpdateDTO.Name && s.Id != id);

            if (course != null)
            {
                throw new ProjectException("This teacher already exist");
            }

            existcourse = await unitOfWork.Courses.UpdateAsync(mapper.Map<Course>(CourseForUpdateDTO));

            await unitOfWork.SaveChangesAsync();

            return mapper.Map<CourseForViewDTO>(existcourse);
        }
    }
}
