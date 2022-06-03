using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(txt_Email.Text, txt_Password.Text);

            if (user != null)
            {
                var usersession = Session["user"];
                HttpContext.Current.Session.Add("admin", true);

                Response.Redirect("~/Forms/Employee.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";

            }
        }

    }
}