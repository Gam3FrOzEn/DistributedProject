namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Byte(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HotDogId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.HotDogs", t => t.HotDogId, cascadeDelete: true)
                .Index(t => t.HotDogId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "HotDogId", "dbo.HotDogs");
            DropForeignKey("dbo.Sales", "ClientId", "dbo.Clients");
            DropIndex("dbo.Sales", new[] { "ClientId" });
            DropIndex("dbo.Sales", new[] { "HotDogId" });
            DropTable("dbo.Sales");
        }
    }
}
