using Financeiro.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Financeiro
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Items["DbContext"] = new FinanceiroContext();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var dbContext = HttpContext.Current.Items["DbContext"] as FinanceiroContext;
            dbContext?.Dispose();
        }
    }
}