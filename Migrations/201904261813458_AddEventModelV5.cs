namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventModelV5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "Host_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.Events", name: "IX_Host_Id", newName: "IX_ApplicationUser_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Events", name: "IX_ApplicationUser_Id", newName: "IX_Host_Id");
            RenameColumn(table: "dbo.Events", name: "ApplicationUser_Id", newName: "Host_Id");
        }
    }
}
