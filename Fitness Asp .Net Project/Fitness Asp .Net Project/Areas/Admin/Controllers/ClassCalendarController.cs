using Fitness_Asp.Net_Project.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    [Auth]
    public class ClassCalendarController : Controller
    {
        // GET: Admin/ClassCalendar
        public ActionResult Index()
        {
            return View();
        }
    }
}