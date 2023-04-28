using ADOCrud.Domain.Commons;
using ADOCrud.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Domain.Entities.Students
{
    public class Student : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
