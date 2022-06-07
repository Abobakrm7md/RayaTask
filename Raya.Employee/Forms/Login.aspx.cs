using log4net;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Raya.Employee.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raya.Employee.Forms
{
    public partial class Login : System.Web.UI.Page
    {
        ILog logger = LogManager.GetLogger("ErrorLog");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeContext())
            {
                var user = context.Users.FirstOrDefault(x => x.UserName == txt_UserName.Text);
                if (user != null)
                {
                    PasswordHasher hasher = new PasswordHasher();
                    var validatePassword = hasher.VerifyHashedPassword(user.PasswordHash, txt_Password.Text);
                    if (validatePassword == PasswordVerificationResult.Success)
                    {
                        HttpContext.Current.Session.Add("user", user);
                        Response.Redirect("~/Forms/Employees.aspx");
                    }
                }

            }
            dvMessage.Visible = true;
            lblMessage.Text = "Invalid username or password.";
        
        }

    }
}