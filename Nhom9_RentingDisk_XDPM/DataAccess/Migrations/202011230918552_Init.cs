namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        idCategory = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        rentalPeriod = c.Int(nullable: false),
                        rentalCharge = c.Single(nullable: false),
                        lateFee = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idCategory);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        idCustomer = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        address = c.String(),
                        phoneNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idCustomer);
            
            CreateTable(
                "dbo.Disks",
                c => new
                    {
                        idDisk = c.String(nullable: false, maxLength: 128),
                        status = c.Int(nullable: false),
                        idTitle = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.idDisk)
                .ForeignKey("dbo.Titles", t => t.idTitle)
                .Index(t => t.idTitle);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        idTitle = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        numberOfCopies = c.Int(nullable: false),
                        idCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idTitle)
                .ForeignKey("dbo.Categories", t => t.idCategory, cascadeDelete: true)
                .Index(t => t.idCategory);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        idCustomer = c.Int(nullable: false),
                        idDisk = c.String(nullable: false, maxLength: 128),
                        idTitle = c.String(nullable: false, maxLength: 128),
                        RentDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        ActualReturnDate = c.DateTime(nullable: false),
                        LateFee = c.Single(nullable: false),
                        isPaid = c.Boolean(nullable: false),
                        isRecord = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.idCustomer, t.idDisk, t.idTitle })
                .ForeignKey("dbo.Customers", t => t.idCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Disks", t => t.idDisk, cascadeDelete: true)
                .ForeignKey("dbo.Titles", t => t.idTitle, cascadeDelete: true)
                .Index(t => t.idCustomer)
                .Index(t => t.idDisk)
                .Index(t => t.idTitle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "idTitle", "dbo.Titles");
            DropForeignKey("dbo.Records", "idDisk", "dbo.Disks");
            DropForeignKey("dbo.Records", "idCustomer", "dbo.Customers");
            DropForeignKey("dbo.Disks", "idTitle", "dbo.Titles");
            DropForeignKey("dbo.Titles", "idCategory", "dbo.Categories");
            DropIndex("dbo.Records", new[] { "idTitle" });
            DropIndex("dbo.Records", new[] { "idDisk" });
            DropIndex("dbo.Records", new[] { "idCustomer" });
            DropIndex("dbo.Titles", new[] { "idCategory" });
            DropIndex("dbo.Disks", new[] { "idTitle" });
            DropTable("dbo.Records");
            DropTable("dbo.Titles");
            DropTable("dbo.Disks");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
