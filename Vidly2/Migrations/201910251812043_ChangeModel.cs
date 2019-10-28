namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 99));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
        }
    }
}
