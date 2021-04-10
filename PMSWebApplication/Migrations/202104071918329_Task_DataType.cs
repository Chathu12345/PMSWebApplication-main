namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Task_DataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "TaskStages", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "TaskStages", c => c.String());
        }
    }
}
