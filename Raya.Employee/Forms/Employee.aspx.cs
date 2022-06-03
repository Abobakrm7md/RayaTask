using Raya.Employee.EntityModel;
using Raya.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raya.Employee.Forms
{
    public partial class Employee : System.Web.UI.Page
    {
        EmployeeContext context;
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            if (userSession != null && userSession.IsAdmin) { Confirm.Visible = true; }
            else { Confirm.Visible = false; }
            LoadEmployeeDataAndFillGridView();
        }

        private void LoadEmployeeDataAndFillGridView()
        {
            using (context = new EmployeeContext())
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
                              }).ToList();
                grdEmployee.DataSource = result;
                grdEmployee.DataBind();
            }
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            using (context = new EmployeeContext())
            {

            }
        }
    }
}