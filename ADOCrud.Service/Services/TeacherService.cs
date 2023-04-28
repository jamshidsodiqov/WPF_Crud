using ADOCrud.Data.Repository;
using ADOCrud.Domain.Configuration;
using ADOCrud.Domain.Entities.Teachers;
using ADOCrud.Service.DTOs.Teachers;
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
    public class TeacherService : ITeacherService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public TeacherService()
        {
            unitOfWork = new UnitOfWork();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public async ValueTask<TeacherForViewDTO> CreateAsync(TeacherForCreationDTO TeacherForCreationDTO)
        {
            var existTeacher = await unitOfWork.Teachers.GetAsync(e => e.Email == TeacherForCreationDTO.Email);

            if (existTeacher != null)
            {
                throw new ProjectException("This teacher created already");
            }
            var createdTeacher = await unitOfWork.Teachers.CreateAsync(mapper.Map<Teacher>(TeacherForCreationDTO));
            await unitOfWork.SaveChangesAsync();

            return mapper.Map<TeacherForViewDTO>(createdTeacher);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var deletedteacher = await unitOfWork.Teachers.DeleteAsync(id);

            if (!deletedteacher)
            {
                throw new ProjectException("Teacher not found");
            }

            await unitOfWork.SaveChangesAsync();

            return true;
        }

        public async ValueTask<IEnumerable<TeacherForViewDTO>> GetAllAsync(PaginationParams @params, Expression<Func<Teacher, bool>> expression = null)
        {
            var teachers = unitOfWork.Teachers.GetAll(expression, isTracking: false);

            return mapper.Map<IEnumerable<TeacherForViewDTO>>(await teachers.ToPagedList(@params).ToListAsync());
        }

        public async ValueTask<TeacherForViewDTO> GetAsync(Expression<Func<Teacher, bool>> expression)
        {
            var teacher = unitOfWork.Teachers.GetAsync(expression, new string[] {"Teachers"},isTracking: false);

            if (teacher == null)
                throw new ProjectException("Teacher not found");

            return mapper.Map<TeacherForViewDTO>(teacher);
        }

        public async ValueTask<TeacherForViewDTO> UpdateAsync(int id, TeacherForUpdateDTO TeacherForUpdateDTO)
        {
            var existTeacher = await unitOfWork.Teachers.GetAsync(s => s.Id == id);

            if (existTeacher == null)
                throw new ProjectException("404 Teacher not found");

            var Teacher = await unitOfWork.Teachers.GetAsync(s => s.Email == TeacherForUpdateDTO.Email && s.Id != id);

            if (Teacher != null)
                throw new ProjectException("This student already exist");

            existTeacher = await unitOfWork.Teachers.UpdateAsync(mapper.Map<Teacher>(TeacherForUpdateDTO));

            await unitOfWork.SaveChangesAsync();

            return mapper.Map<TeacherForViewDTO>(existTeacher);
        }
    }
}
