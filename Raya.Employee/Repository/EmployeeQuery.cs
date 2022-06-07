using Raya.Employee.Models;
using System.Collections.Generic;
using System.Linq;

namespace Raya.Employee.Repository
{
    public static class EmployeeQuery
    {
        public static EmployeeContext context;
        static EmployeeQuery()
        {
            context = new EmployeeContext();
        }
        public static List<EmpolyeeModel> GetEmployees()
        {
            var result = (from emp in context.Employees
                          join dept in context.Departments on emp.departmentId equals dept.Id
                          from user in context.Users.Where(x => x.Id == emp.CreatedBy || x.Id == emp.ModifiedBy)
                          select new EmpolyeeModel
                          {
                              EmployeeId = emp.Id,
                              Address = emp.Address,
                              Phone = emp.Phone,
                              EmpName = emp.Name,
                              BirthDate = emp.BirthDate,
                              HireDate = emp.HireDate,
                              Department = dept.Name,
                              CreatedDate = emp.CreatedDate,
                              CreateBy = user.Email,
                              ModifiedDate = emp.ModifiedDate,
                              ModifiedBy = user.Email,
                              Confirmed = emp.Confirmed == true ? "Confirmed" : "NotConfirmed"
                          }).ToList();
            return result;
        }
    }
}