namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenericAdminAndEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoffeeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        RegularCoffee = c.Int(nullable: false),
                        DecafCoffee = c.Int(nullable: false),
                        Latte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoffeeModels");
        }
    }
}
