namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTask : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "TaskWisePayment");
            DropColumn("dbo.Tasks", "PaymentDueDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "PaymentDueDate", c => c.DateTime(storeType: "date"));
            AddColumn("dbo.Tasks", "TaskWisePayment", c => c.Int(nullable: false));
        }
    }
}
