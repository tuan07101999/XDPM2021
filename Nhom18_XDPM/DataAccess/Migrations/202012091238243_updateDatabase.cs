namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Records");
            AddColumn("dbo.Disks", "name", c => c.String());
            AddColumn("dbo.Records", "idRecord", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Records", "rentDate", c => c.DateTime());
            AlterColumn("dbo.Records", "dueDate", c => c.DateTime());
            AlterColumn("dbo.Records", "actualReturnDate", c => c.DateTime());
            AlterColumn("dbo.Records", "lateFee", c => c.Single());
            AddPrimaryKey("dbo.Records", new[] { "idRecord", "idCustomer", "idDisk", "idTitle" });
            DropColumn("dbo.Records", "isRecord");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Records", "isRecord", c => c.Boolean(nullable: false));
            DropPrimaryKey("dbo.Records");
            AlterColumn("dbo.Records", "lateFee", c => c.Single(nullable: false));
            AlterColumn("dbo.Records", "actualReturnDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Records", "dueDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Records", "rentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Records", "idRecord");
            DropColumn("dbo.Disks", "name");
            AddPrimaryKey("dbo.Records", new[] { "idCustomer", "idDisk", "idTitle" });
        }
    }
}
