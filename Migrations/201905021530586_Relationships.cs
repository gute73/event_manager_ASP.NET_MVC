namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "ApplicationUserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "ApplicationUserID");
        }
    }
}
