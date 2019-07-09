namespace Fitness_Asp.Net_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AdminUsers", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.AdminUsers", new[] { "Email" });
        }
    }
}
