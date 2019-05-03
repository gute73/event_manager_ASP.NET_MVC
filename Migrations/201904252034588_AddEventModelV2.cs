namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventModelV2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "EventTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Events", "EventDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Events", "EventTime");
            DropColumn("dbo.Events", "EventDate");
        }
    }
}
