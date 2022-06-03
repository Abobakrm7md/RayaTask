using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Raya.Employee.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raya.Employee.Forms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeContext())
            {
                var user = new ApplicationUser()
                {
                    Email = Email.Text,
                    UserName = Email.Text,
                    IsAdmin = bool.Parse(IsAdmin.SelectedValue.ToString())
                };
                PasswordHasher hasher = new PasswordHasher();
                user.PasswordHash = hasher.HashPassword(Password.Text);
                context.Users.Add(user);
                context.SaveChanges();
                Response.Redirect("~/Forms/Login.aspx");
            }
        }
    }
}