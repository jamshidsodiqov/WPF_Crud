using ADOCrud.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Domain.Entities.Teachers
{
    public class Teacher : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Field { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
