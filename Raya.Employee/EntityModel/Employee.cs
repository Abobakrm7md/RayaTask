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
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int? departmentId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public bool Confirmed { get; set; }
        public virtual Department Department { get; set; }
        public virtual ApplicationUser  User { get; set; }

    }
}