using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class Calendars
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Day { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        [AllowHtml]
        public string Description { get; set; }






    }
}