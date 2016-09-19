namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
