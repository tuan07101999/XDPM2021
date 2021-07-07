namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHoldingEntity_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Holdings",
                c => new
                    {
                        idHolding = c.Int(nullable: false, identity: true),
                        idCustomer = c.Int(nullable: false),
                        idTitle = c.String(maxLength: 128),
                        reservationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idHolding)
                .ForeignKey("dbo.Customers", t => t.idCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Titles", t => t.idTitle)
                .Index(t => t.idCustomer)
                .Index(t => t.idTitle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Holdings", "idTitle", "dbo.Titles");
            DropForeignKey("dbo.Holdings", "idCustomer", "dbo.Customers");
            DropIndex("dbo.Holdings", new[] { "idTitle" });
            DropIndex("dbo.Holdings", new[] { "idCustomer" });
            DropTable("dbo.Holdings");
        }
    }
}
