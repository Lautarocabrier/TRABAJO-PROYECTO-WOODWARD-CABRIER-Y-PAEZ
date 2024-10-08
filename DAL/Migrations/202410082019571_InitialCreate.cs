namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Schedule = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        IdNumber = c.String(),
                        Email = c.String(),
                        MonthlySubscription = c.Int(nullable: false),
                        GymId = c.Int(nullable: false),
                        Manager_GymId = c.Int(),
                        Manager_GymId1 = c.Int(),
                        Manager_GymId2 = c.Int(),
                        Manager_GymId3 = c.Int(),
                        Manager_GymId4 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Managers", t => t.Manager_GymId)
                .ForeignKey("dbo.Managers", t => t.Manager_GymId1)
                .ForeignKey("dbo.Managers", t => t.Manager_GymId2)
                .ForeignKey("dbo.Managers", t => t.Manager_GymId3)
                .ForeignKey("dbo.Managers", t => t.Manager_GymId4)
                .ForeignKey("dbo.Managers", t => t.GymId, cascadeDelete: true)
                .Index(t => t.GymId)
                .Index(t => t.Manager_GymId)
                .Index(t => t.Manager_GymId1)
                .Index(t => t.Manager_GymId2)
                .Index(t => t.Manager_GymId3)
                .Index(t => t.Manager_GymId4);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        GymId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TaxId = c.String(),
                    })
                .PrimaryKey(t => t.GymId);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Id = c.Int(),
                        UserId = c.Int(),
                        EntryDate = c.DateTime(),
                        ExitDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EntryId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        NumberOfDays = c.Int(nullable: false),
                        PriceValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NumberOfDays, t.PriceValue });
            
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Activity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Activity_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Activity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "GymId", "dbo.Managers");
            DropForeignKey("dbo.Users", "Manager_GymId4", "dbo.Managers");
            DropForeignKey("dbo.Users", "Manager_GymId3", "dbo.Managers");
            DropForeignKey("dbo.Users", "Manager_GymId2", "dbo.Managers");
            DropForeignKey("dbo.Users", "Manager_GymId1", "dbo.Managers");
            DropForeignKey("dbo.Users", "Manager_GymId", "dbo.Managers");
            DropForeignKey("dbo.UserActivities", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.UserActivities", "User_Id", "dbo.Users");
            DropIndex("dbo.UserActivities", new[] { "Activity_Id" });
            DropIndex("dbo.UserActivities", new[] { "User_Id" });
            DropIndex("dbo.Entries", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Manager_GymId4" });
            DropIndex("dbo.Users", new[] { "Manager_GymId3" });
            DropIndex("dbo.Users", new[] { "Manager_GymId2" });
            DropIndex("dbo.Users", new[] { "Manager_GymId1" });
            DropIndex("dbo.Users", new[] { "Manager_GymId" });
            DropIndex("dbo.Users", new[] { "GymId" });
            DropTable("dbo.UserActivities");
            DropTable("dbo.Prices");
            DropTable("dbo.Entries");
            DropTable("dbo.Managers");
            DropTable("dbo.Users");
            DropTable("dbo.Activities");
        }
    }
}
