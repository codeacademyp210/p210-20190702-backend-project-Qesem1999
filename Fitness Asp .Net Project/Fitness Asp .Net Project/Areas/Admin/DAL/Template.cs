using Fitness_Asp.Net_Project.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fitness_Asp.Net_Project.Areas.Admin.DAL
{
    public class Template : DbContext
    {
        public Template():base("Template")
        {
        }

        public DbSet<Calendars> Calendars { get; set; }
        public DbSet<ClubInfos> ClubInfo { get; set; }

        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Cources> Cources { get; set; }
        public DbSet<CourseSchedules> CourseSchedule { get; set; }
        public DbSet<Packages> Packages { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<UserLists> UserLists { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Days> Day { get; set; }








    }
}