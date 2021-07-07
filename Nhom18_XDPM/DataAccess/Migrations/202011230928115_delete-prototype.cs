namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteprototype : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "BirthDate");
            DropColumn("dbo.Records", "RentDate");
            DropColumn("dbo.Records", "DueDate");
            DropColumn("dbo.Records", "ActualReturnDate");
            DropColumn("dbo.Records", "LateFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Records", "LateFee", c => c.Single(nullable: false));
            AddColumn("dbo.Records", "ActualReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "DueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Records", "RentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
