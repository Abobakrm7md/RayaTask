using Raya.Employee.EntityModel;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationUser userSession = (ApplicationUser)Session["user"];
            if (userSession.IsAdmin) { }
        }
    }
}