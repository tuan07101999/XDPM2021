namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRecord : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Records", "idDisk", "dbo.Disks");
            DropForeignKey("dbo.Records", "idTitle", "dbo.Titles");
            DropIndex("dbo.Records", new[] { "idDisk" });
            DropIndex("dbo.Records", new[] { "idTitle" });
            DropPrimaryKey("dbo.Records");
            AlterColumn("dbo.Records", "idDisk", c => c.String(maxLength: 128));
            AlterColumn("dbo.Records", "idTitle", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Records", "idRecord");
            CreateIndex("dbo.Records", "idDisk");
            CreateIndex("dbo.Records", "idTitle");
            AddForeignKey("dbo.Records", "idDisk", "dbo.Disks", "idDisk");
            AddForeignKey("dbo.Records", "idTitle", "dbo.Titles", "idTitle");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "idTitle", "dbo.Titles");
            DropForeignKey("dbo.Records", "idDisk", "dbo.Disks");
            DropIndex("dbo.Records", new[] { "idTitle" });
            DropIndex("dbo.Records", new[] { "idDisk" });
            DropPrimaryKey("dbo.Records");
            AlterColumn("dbo.Records", "idTitle", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Records", "idDisk", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Records", new[] { "idRecord", "idCustomer", "idDisk", "idTitle" });
            CreateIndex("dbo.Records", "idTitle");
            CreateIndex("dbo.Records", "idDisk");
            AddForeignKey("dbo.Records", "idTitle", "dbo.Titles", "idTitle", cascadeDelete: true);
            AddForeignKey("dbo.Records", "idDisk", "dbo.Disks", "idDisk", cascadeDelete: true);
        }
    }
}
