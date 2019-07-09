
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class Coupons
    {
        public int Id { get; set; }
        public string CouponsName { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }
        public string Code { get; set; }

    }
}