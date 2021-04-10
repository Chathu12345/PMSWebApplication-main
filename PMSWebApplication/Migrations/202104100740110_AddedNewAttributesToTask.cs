namespace PMSWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewAttributesToTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "TaskWisePayment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Tasks", "PaymentDueDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "PaymentDueDate");
            DropColumn("dbo.Tasks", "TaskWisePayment");
        }
    }
}
