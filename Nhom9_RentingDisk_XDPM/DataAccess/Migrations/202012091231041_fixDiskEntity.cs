namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDiskEntity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Disks", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Disks", "Name", c => c.String());
        }
    }
}
