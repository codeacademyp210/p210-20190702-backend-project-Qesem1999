using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class UserLists
    {
        public int Id { get; set; }
        public int UserNameId { get; set; }
        public int EmailId { get; set; }
        public int NumberId { get; set; }
        public int StatusId { get; set; }

        public UserProfile User { get; set; }

    }
}