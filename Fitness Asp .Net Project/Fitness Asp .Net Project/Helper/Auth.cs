using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Helper
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["IsLogin2"] == null || (bool)HttpContext.Current.Session["IsLogin2"] == false)
            {
                filterContext.Result = new RedirectResult("Admin/Admin/Index");
            }

            base.OnActionExecuting(filterContext);
        }

    }
}