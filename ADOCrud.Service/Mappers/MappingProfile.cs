using ADOCrud.Domain.Entities.Courses;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Domain.Entities.Teachers;
using ADOCrud.Service.DTOs.Courses;
using ADOCrud.Service.DTOs.Students;
using ADOCrud.Service.DTOs.Teachers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Teacher, TeacherForCreationDTO>().ReverseMap();
            CreateMap<Teacher, TeacherForUpdateDTO>().ReverseMap();
            CreateMap<Teacher, TeacherForViewDTO>().ReverseMap();

            CreateMap<Student, StudentForCreationDTO>().ReverseMap();
            CreateMap<Student, StudentForUpdateDTO>().ReverseMap();
            CreateMap<Student, StudentForViewDTO>().ReverseMap();

            CreateMap<Course, CourseForCreationDTO>().ReverseMap();
            CreateMap<Course, CourseForUpdateDTO>().ReverseMap();
            CreateMap<Course, CourseForViewDTO>().ReverseMap();
        }
    }
}
