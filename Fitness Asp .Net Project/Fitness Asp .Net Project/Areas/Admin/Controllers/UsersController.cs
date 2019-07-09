using Fitness_Asp.Net_Project.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    [Auth]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult UsersList()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult AddUsers()
        {
            return View();
        }
        public ActionResult Payments()
        {
            return View();
        }
    }
}