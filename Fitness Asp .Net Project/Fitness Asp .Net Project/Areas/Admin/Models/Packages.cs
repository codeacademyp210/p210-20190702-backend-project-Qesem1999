using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class Packages
    {

        public int Id { get; set; }
        public string PackagesName { get; set; }
        public string Duration { get; set; }
        public string Desciption { get; set; }
        public string Amount { get; set; }
        
    }
}