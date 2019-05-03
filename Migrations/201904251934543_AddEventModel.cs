namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 250),
                        EventDateTime = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 250),
                        Title = c.String(nullable: false, maxLength: 30),
                        Host_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.AspNetUsers", t => t.Host_Id, cascadeDelete: true)
                .Index(t => t.Host_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Host_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Host_Id" });
            DropTable("dbo.Events");
        }
    }
}
