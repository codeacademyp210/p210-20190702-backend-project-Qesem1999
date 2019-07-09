namespace Fitness_Asp.Net_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createdatabaseandtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Category = c.String(),
                        Day = c.String(),
                        From = c.String(),
                        To = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClubInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Username = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Adress = c.String(),
                        City = c.String(),
                        PinCode = c.Int(nullable: false),
                        Fax = c.Int(nullable: false),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CouponsName = c.String(),
                        Duration = c.String(),
                        Description = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Duration = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        From = c.String(),
                        To = c.String(),
                        DayId = c.Int(nullable: false),
                        Cource_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cources", t => t.Cource_Id)
                .ForeignKey("dbo.Days", t => t.DayId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .Index(t => t.TrainerId)
                .Index(t => t.RoomId)
                .Index(t => t.DayId)
                .Index(t => t.Cource_Id);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainerName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackagesName = c.String(),
                        Duration = c.String(),
                        Desciption = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserNameId = c.Int(nullable: false),
                        CourceId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        EmailId = c.Int(nullable: false),
                        PaymentDue = c.String(),
                        TotalAmaunt = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cources", t => t.CourceId, cascadeDelete: true)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .ForeignKey("dbo.UserProfiles", t => t.User_Id)
                .Index(t => t.CourceId)
                .Index(t => t.TrainerId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Gender = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Height = c.Single(nullable: false),
                        Weight = c.String(),
                        Email = c.String(),
                        ContactNumber = c.String(),
                        Address = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserNameId = c.Int(nullable: false),
                        EmailId = c.Int(nullable: false),
                        NumberId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLists", "User_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.Payments", "User_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.Payments", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.Payments", "CourceId", "dbo.Cources");
            DropForeignKey("dbo.CourseSchedules", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.CourseSchedules", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.CourseSchedules", "DayId", "dbo.Days");
            DropForeignKey("dbo.CourseSchedules", "Cource_Id", "dbo.Cources");
            DropIndex("dbo.UserLists", new[] { "User_Id" });
            DropIndex("dbo.Payments", new[] { "User_Id" });
            DropIndex("dbo.Payments", new[] { "TrainerId" });
            DropIndex("dbo.Payments", new[] { "CourceId" });
            DropIndex("dbo.CourseSchedules", new[] { "Cource_Id" });
            DropIndex("dbo.CourseSchedules", new[] { "DayId" });
            DropIndex("dbo.CourseSchedules", new[] { "RoomId" });
            DropIndex("dbo.CourseSchedules", new[] { "TrainerId" });
            DropTable("dbo.UserLists");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Payments");
            DropTable("dbo.Packages");
            DropTable("dbo.Trainers");
            DropTable("dbo.Rooms");
            DropTable("dbo.Days");
            DropTable("dbo.CourseSchedules");
            DropTable("dbo.Cources");
            DropTable("dbo.Coupons");
            DropTable("dbo.ClubInfos");
            DropTable("dbo.Calendars");
            DropTable("dbo.AdminUsers");
        }
    }
}
