using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Raya.Employee
{
    public class Global : HttpApplication
    {
        ILog logger = LogManager.GetLogger("ErrorLog");

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();
        }
        public override void Init()
        {
            base.Init();
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
            logger.Error(ex);
            Server.ClearError();

            Response.Redirect("~/Forms/Errors/Error.aspx");
        }
    }
}