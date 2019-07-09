using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public int UserNameId { get; set; }
        public int CourceId { get; set; }
        public int TrainerId { get; set; }
        public int EmailId { get; set; }
        public string PaymentDue { get; set; }
        public string TotalAmaunt { get; set; }

        public Cources Cource { get; set; }
        public UserProfile User { get; set; }
        public Trainers Trainer { get; set; }
    }
}