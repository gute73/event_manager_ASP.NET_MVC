namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationshipsv3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "ApplicationUser_Id" });
            AlterColumn("dbo.Events", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Events", "ApplicationUser_Id");
            AddForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "ApplicationUser_Id" });
            AlterColumn("dbo.Events", "ApplicationUser_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Events", "ApplicationUser_Id");
            AddForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
