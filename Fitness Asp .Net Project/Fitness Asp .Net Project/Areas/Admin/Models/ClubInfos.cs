using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class ClubInfos
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public int Fax { get; set; }
        public string Website { get; set; }
    }
}