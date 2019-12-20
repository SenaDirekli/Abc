using Abc.Mvc.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrunKatalog.Entitiy;

namespace Abc.Mvc.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object BundleTable { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());
        }
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session == null) return;

            var cultureInfo = (CultureInfo)Session["Culture"];
            if (cultureInfo == null)
            {
                var languageName = "tr";
                cultureInfo = new CultureInfo(languageName);
                Session["Culture"] = cultureInfo;
            }

            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
        }
    }
}
