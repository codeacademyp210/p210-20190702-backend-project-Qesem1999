using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Fitness_Asp.Net_Project.Areas.Admin.Controllers" }
            );
            context.MapRoute(
                "Admin_default_old",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Fitness_Asp.Net_Project.Areas.Admin.Controllers" }
            );
        }
    }
}