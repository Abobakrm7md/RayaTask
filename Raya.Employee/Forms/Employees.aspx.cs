using Raya.Employee.EntityModel;
using Raya.Employee.Models;
using Raya.Employee.Repository;
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
            var employees = Repository.EmployeeQuery.GetEmployees();
            grdEmployee.DataSource = employees;
            grdEmployee.DataBind();
        }
        private void LoadDepartment()
        {
            if (!IsPostBack)
            {
               var departments = RepositoryBase<Department>.Get();
                dept.DataSource = departments;
                dept.DataValueField = "Id";
                dept.DataTextField = "Name";
                dept.DataBind();
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
            RepositoryBase<EntityModel.Employee>.Add(emp);
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
            var employee = RepositoryBase<EntityModel.Employee>.GetById(empId);
            InitializeConrolesByEmployee(employee);
        }
        private void InitializeConrolesByEmployee(EntityModel.Employee employee)
        {
            EmpId.Text = employee.Id.ToString();
            txt_Name.Text = employee.Name;
            txt_Phone.Text = employee.Phone;
            BirthDate.Text = employee.BirthDate.Value.ToString("dd/MM/yyyy");
            HireDate.Text = employee.HireDate.ToString();
            txt_Address.Text = employee.Address;
            dept.SelectedValue = employee.departmentId.ToString();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            int empId = int.Parse(EmpId.Text.ToString());
            var employee = RepositoryBase<EntityModel.Employee>.GetById(empId);
            employee.Name = txt_Name.Text;
            employee.Address = txt_Address.Text;
            employee.Phone = txt_Phone.Text;
            employee.BirthDate = DateTime.Now;
            employee.HireDate = DateTime.Now;
            employee.departmentId = int.Parse(dept.SelectedValue.ToString());
            employee.ModifiedBy = userSession.Id;
            employee.ModifiedDate = DateTime.Now;

            RepositoryBase<EntityModel.Employee>.Update(employee);
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            var employee = RepositoryBase<EntityModel.Employee>.GetById(empId);
            if (employee == null)
                return;
            RepositoryBase < EntityModel.Employee >.Delete(employee);
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(EmpId.Text);
            var employee = RepositoryBase<EntityModel.Employee>.GetById(empId);
            employee.Confirmed = true;
            RepositoryBase< EntityModel.Employee >.Update(employee);
            LoadEmployeeDataAndFillGridView();
            ResetControls();
        }
    }
}