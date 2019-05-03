namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        ApplicationUserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RegistrationID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID)
                .Index(t => t.ApplicationUserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "EventID", "dbo.Events");
            DropForeignKey("dbo.Registrations", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Registrations", new[] { "ApplicationUserID" });
            DropIndex("dbo.Registrations", new[] { "EventID" });
            DropTable("dbo.Registrations");
        }
    }
}
