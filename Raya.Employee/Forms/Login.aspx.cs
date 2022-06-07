using log4net;
using Microsoft.AspNet.Identity;
using Raya.Employee.ApplicationGlobal;
using System;
using System.Linq;
using System.Web;

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
                        Response.Redirect(ApplicationUrls.Employee);
                    }
                }

            }
            dvMessage.Visible = true;
            lblMessage.Text = "Invalid username or password.";
        
        }

    }
}