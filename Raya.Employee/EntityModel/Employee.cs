using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raya.Employee.EntityModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int? departmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}