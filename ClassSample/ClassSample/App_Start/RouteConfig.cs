using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;

namespace ClassSample
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Login",
                 "Login",
                 "~/Pages/Login.aspx");

            routes.MapPageRoute("Deparments",
                "Deparments",
                "~/Pages/Deparments.aspx");
        }
    }
}
