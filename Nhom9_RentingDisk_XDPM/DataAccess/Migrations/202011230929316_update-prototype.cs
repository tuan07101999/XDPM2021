namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateprototype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "rentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "dueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "actualReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "lateFee", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Records", "lateFee");
            DropColumn("dbo.Records", "actualReturnDate");
            DropColumn("dbo.Records", "dueDate");
            DropColumn("dbo.Records", "rentDate");
            DropColumn("dbo.Customers", "birthDate");
        }
    }
}
