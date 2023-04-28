using ADOCrud.Domain.Commons;
using ADOCrud.Domain.Entities.Students;
using ADOCrud.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Domain.Entities.Courses
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
        public CourseType CourseType { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
