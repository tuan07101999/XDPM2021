namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHoldingEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Records", "idTitle", "dbo.Titles");
            DropIndex("dbo.Records", new[] { "idTitle" });
            DropColumn("dbo.Records", "idTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Records", "idTitle", c => c.String(maxLength: 128));
            CreateIndex("dbo.Records", "idTitle");
            AddForeignKey("dbo.Records", "idTitle", "dbo.Titles", "idTitle");
        }
    }
}
