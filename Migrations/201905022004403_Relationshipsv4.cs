namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationshipsv4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Events", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Events", "ApplicationUserID");
            RenameColumn(table: "dbo.Events", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            AlterColumn("dbo.Events", "ApplicationUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Events", "ApplicationUserID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Events", new[] { "ApplicationUserID" });
            AlterColumn("dbo.Events", "ApplicationUserID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Events", name: "ApplicationUserID", newName: "ApplicationUser_Id");
            AddColumn("dbo.Events", "ApplicationUserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "ApplicationUser_Id");
        }
    }
}
