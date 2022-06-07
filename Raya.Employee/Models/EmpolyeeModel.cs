using System;

namespace Raya.Employee.Models
{
    public class EmpolyeeModel
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public DateTime? HireDate { get; set; }
        public string Confirmed { get; set; }

    }
}