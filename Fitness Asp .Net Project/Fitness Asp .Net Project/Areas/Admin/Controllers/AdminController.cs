using Fitness_Asp.Net_Project.Areas.Admin.DAL;
using Fitness_Asp.Net_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        private readonly Template db;

        public AdminController()
        {
            db = new Template();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signin(AdminUser adminUser)
        {
            bool isLogin = false;

            if (string.IsNullOrEmpty(adminUser.Email) || string.IsNullOrEmpty(adminUser.Password))
            {
                Session["LoginError"] = "Email ve ya Password bos qoyula bilmez";
                return RedirectToAction("Index", "Admin");
            }

            AdminUser adm = db.AdminUser.FirstOrDefault(a => a.Email == adminUser.Email);

            if (adm != null)
            {
                isLogin = Crypto.VerifyHashedPassword(adm.Password, adminUser.Password);

                if (isLogin)
                {
                    Session["IsLogin2"] = isLogin;
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }

            }

            Session["LoginError"] = "email ve ya password sehvdir";
            return RedirectToAction("Index", "Admin");


        } 
        public ActionResult Hash()
        {
            string a = "admin";
            string b = Crypto.HashPassword(a);
            return Content(b);
        }
    }
}