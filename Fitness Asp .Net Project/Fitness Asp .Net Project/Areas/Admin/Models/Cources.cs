using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class Cources
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }
    }
}