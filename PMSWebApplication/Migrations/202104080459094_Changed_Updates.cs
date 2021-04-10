namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_Updates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Updates", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Updates", new[] { "UserId" });
            AddColumn("dbo.Updates", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Updates", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Updates", "UserId");
            AddForeignKey("dbo.Updates", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Updates", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Updates", new[] { "UserId" });
            AlterColumn("dbo.Updates", "UserId", c => c.String(maxLength: 128));
            DropColumn("dbo.Updates", "Description");
            CreateIndex("dbo.Updates", "UserId");
            AddForeignKey("dbo.Updates", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
