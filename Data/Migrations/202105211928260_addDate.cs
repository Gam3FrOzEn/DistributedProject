namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Sales", "Date");
        }
    }
}
