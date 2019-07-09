using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class CourseSchedules
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TrainerId { get; set; }
        public int RoomId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int DayId { get; set; }
        [AllowHtml]
        public string Description { get; set; }

        public Cources Cource { get; set; }
        public Trainers Trainer { get; set; }
        public Rooms Room { get; set; }
        public Days Day { get; set; }

    }
}