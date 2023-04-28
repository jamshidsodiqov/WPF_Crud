using ADOCrud.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Service.DTOs.Courses
{
    public class CourseForUpdateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public CourseType CourseType { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
