using Fitness_Asp.Net_Project.Helper;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    [Auth]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
           
            return View();
        }

    }
}
