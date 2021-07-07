namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameDisk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Disks", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Disks", "name");
        }
    }
}
