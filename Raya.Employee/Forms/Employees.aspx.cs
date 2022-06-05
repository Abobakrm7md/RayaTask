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
    public partial class Employees : System.Web.UI.Page
    {
        EmployeeContext context;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidateUserTypeToDisableEnableControls();
                LoadEmployeeDataAndFillGridView();
                LoadDepartment();
            }
        }

        private void ValidateUserTypeToDisableEnableControls()
        {
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            if(userSession == null) { Response.Redirect("~/Forms/Login.aspx"); }
            if (userSession.IsAdmin) { Confirm.Visible = true; }
            else { Confirm.Visible = false; 
               }
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
                                  Confirmed = emp.Confirmed == true?"Confirmed":"NotConfirmed"
                              }).ToList();
                grdEmployee.DataSource = result;
                grdEmployee.DataBind();
            }
        }
        private void LoadDepartment()
        {
            if (!IsPostBack)
            {
                using (context = new EmployeeContext())
                {
                    var depts = context.Departments.Distinct().ToList();
                    dept.DataSource = depts;
                    dept.DataValueField = "Id";
                    dept.DataTextField = "Name";
                    dept.DataBind();
                }
            }
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
            LoadEmployeeDataAndFillGridView();
        }
        private void AddNewEmployee()
        {
            //init employee 
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            if(userSession == null)
                Response.Redirect("~/Forms/Login.aspx");
            var emp = new EntityModel.Employee()
            {
                Name = txt_Name.Text,
                Address = txt_Address.Text,
                Phone = txt_Phone.Text,
                BirthDate = DateTime.Now,
                HireDate = DateTime.Now,
                departmentId = int.Parse(dept.SelectedValue.ToString()),
                CreatedBy = userSession.Id,
                CreatedDate = DateTime.Now,
                ModifiedBy = userSession.Id,
                ModifiedDate = DateTime.Now,
            };
            //save emp
            using (context = new EmployeeContext())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
        private void ResetControls()
        {
            txt_Name.Text =string.Empty;
            txt_Phone.Text =string.Empty;
            BirthDate.Text =string.Empty;
            HireDate.Text =string.Empty;
            txt_Address.Text =string.Empty;
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        protected void EmpSelected_Click(object sender , EventArgs e)
        {
            int empId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            var employee = GetEmploee(empId);
            InitializeConrolesByEmployee(employee);
        }
        private EntityModel.Employee GetEmploee(int empId)
        {
            using (var context = new EmployeeContext())
            {
                var emp = context.Employees.Find(empId);
                return emp;
            }
        }
        private void InitializeConrolesByEmployee(EntityModel.Employee employee)
        {
            EmpId.Text = employee.Id.ToString();
            txt_Name.Text = employee.Name;
            txt_Phone.Text = employee.Phone;
            BirthDate.Text = employee.BirthDate.ToString();
            HireDate.Text = employee.HireDate.ToString();
            txt_Address.Text = employee.Address;
            dept.SelectedValue = employee.departmentId.ToString();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            int empId = int.Parse(EmpId.Text.ToString());
            using( context = new EmployeeContext())
            {
                var employee = context.Employees.Find(empId);
                employee.Name = txt_Name.Text;
                employee.Address = txt_Address.Text;
                employee.Phone = txt_Phone.Text;
                employee.BirthDate = DateTime.Now;
                employee.HireDate = DateTime.Now;
                employee.departmentId = int.Parse(dept.SelectedValue.ToString());
                employee.ModifiedBy = userSession.Id;
                employee.ModifiedDate = DateTime.Now;
                //context.Employees.Attach(employee);
                context.SaveChanges();
            }
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(EmpId.Text.ToString());
            using (context = new EmployeeContext())
            {
                var employee = context.Employees.Find(empId);               
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(EmpId.Text);
            using (context = new EmployeeContext())
            {
                var employee = context.Employees.Find(empId);
                employee.Confirmed = true;
                context.SaveChanges();
            }
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }
    }
}