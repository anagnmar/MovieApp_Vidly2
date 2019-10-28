namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (CustomerName, IsSubscribed, MembershipTypeId) VALUES ('John Smith', 1, 3)");
            Sql("INSERT INTO Customers (CustomerName, IsSubscribed, MembershipTypeId) VALUES ('Mary Williams', 1, 1)");
            Sql("INSERT INTO Customers (CustomerName, IsSubscribed, MembershipTypeId) VALUES ('Mark Wahlberg', 0, 2)");
            Sql("INSERT INTO Customers (CustomerName, IsSubscribed, MembershipTypeId) VALUES ('Kate Beckinsale', 0, 4)");
            Sql("INSERT INTO Customers (CustomerName, IsSubscribed, MembershipTypeId) VALUES ('John Smith', 1, 3)");

        }

        public override void Down()
        {
        }
    }
}
