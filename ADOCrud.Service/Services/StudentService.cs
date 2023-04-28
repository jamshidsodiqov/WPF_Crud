using ADOCrud.Data.IRepository;
using ADOCrud.Data.Repository;
using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Service.DTOs.Students;
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
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public StudentService()
        {
            unitOfWork = new UnitOfWork();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }


        public async ValueTask<StudentForViewDTO> CreateAsync(StudentForCreationDTO studentForCreationDTO)
        {
            var existstudent = await unitOfWork.Students.GetAsync(e => e.Email == studentForCreationDTO.Email);

            if (existstudent != null)
            {
                throw new ProjectException("This student created already");
            }

            var createdstudent = await unitOfWork.Students.CreateAsync(mapper.Map<Student>(studentForCreationDTO));

            await unitOfWork.SaveChangesAsync();

            var existcourse = await unitOfWork.Courses.GetAsync(c => c.Id == studentForCreationDTO.CourseId);

            if (existcourse == null)
                throw new ProjectException("Course not found");



            return mapper.Map<StudentForViewDTO>(createdstudent);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var deletedstudent = await unitOfWork.Students.DeleteAsync(id);

            if (!deletedstudent)
            {
                throw new ProjectException("Student not found");
            }

            await unitOfWork.SaveChangesAsync();

            return true;
        }

        public async ValueTask<IEnumerable<StudentForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Student, bool>> expression = null)
        {
            var students = unitOfWork.Students.GetAll(expression, isTracking: false);

            return mapper.Map<IEnumerable<StudentForViewDTO>>(await students.ToPagedList(@params).ToListAsync());
        }

        public async ValueTask<StudentForViewDTO> GetAsync(Expression<Func<Student, bool>> expression)
        {
            var student = unitOfWork.Students.GetAsync(expression, isTracking: false);

            if (student == null)
            {
                throw new ProjectException("Student not found");
            }

            return mapper.Map<StudentForViewDTO>(student);
        }

        public async ValueTask<StudentForViewDTO> UpdateAsync(int id, StudentForUpdateDTO StudentForUpdateDTO)
        {
            var existstudent = await unitOfWork.Students.GetAsync(s => s.Id == id);

            if (existstudent == null)
                throw new ProjectException("404 Student not found");

            var student = await unitOfWork.Students.GetAsync(s => s.Email == StudentForUpdateDTO.Email && s.Id != id);

            if (student != null)
            {
                throw new ProjectException("This Student email already taken");
            }

            existstudent = await unitOfWork.Students.UpdateAsync(mapper.Map<Student>(StudentForUpdateDTO));

            await unitOfWork.SaveChangesAsync();

            return mapper.Map<StudentForViewDTO>(existstudent);

        }
    }
}
