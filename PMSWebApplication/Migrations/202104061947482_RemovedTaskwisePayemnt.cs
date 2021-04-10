namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTaskwisePayemnt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "TaskWisePayment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "TaskWisePayment", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
