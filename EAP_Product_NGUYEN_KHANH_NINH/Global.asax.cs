using EAP_Product_NGUYEN_KHANH_NINH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EAP_Product_NGUYEN_KHANH_NINH
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private DataContext dataContext;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //dataContext = new DataContext();
        }
    }
}
