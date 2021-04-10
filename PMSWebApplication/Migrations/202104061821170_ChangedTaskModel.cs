namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTaskModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "TaskName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Tasks", "SDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Tasks", "Deadline", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Tasks", "EDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Tasks", "AssignedEmployee", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Tasks", "TaskDescription", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "TaskDescription", c => c.String());
            AlterColumn("dbo.Tasks", "AssignedEmployee", c => c.String());
            AlterColumn("dbo.Tasks", "EDate", c => c.DateTime());
            AlterColumn("dbo.Tasks", "Deadline", c => c.DateTime());
            AlterColumn("dbo.Tasks", "SDate", c => c.DateTime());
            AlterColumn("dbo.Tasks", "TaskName", c => c.String());
        }
    }
}
