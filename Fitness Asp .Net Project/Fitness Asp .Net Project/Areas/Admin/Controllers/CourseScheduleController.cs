using Fitness_Asp.Net_Project.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    [Auth]
    public class CourseScheduleController : Controller
    {
        // GET: Admin/CourseSchedule
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Rooms()
        {
            return View();
        }

        public ActionResult Trainers()
        {
            return View();
        }
        




    }
}