namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToolsStarted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EoDLunchOrderModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        ChefSalad = c.Int(nullable: false),
                        CranSalad = c.Int(nullable: false),
                        CaeserSalad = c.Int(nullable: false),
                        RanchDressingCup = c.Int(nullable: false),
                        BalsamicDressingCup = c.Int(nullable: false),
                        Tuna = c.Int(nullable: false),
                        ChickenSaladSam = c.Int(nullable: false),
                        ColdItalian = c.Int(nullable: false),
                        BuffaloRanch = c.Int(nullable: false),
                        BuffaloBleu = c.Int(nullable: false),
                        TurkeyClub = c.Int(nullable: false),
                        BLTCClub = c.Int(nullable: false),
                        PortabelloWrap = c.Int(nullable: false),
                        GrilledCheese = c.Int(nullable: false),
                        TurkeyApple = c.Int(nullable: false),
                        HamCheese = c.Int(nullable: false),
                        BLTCWrap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EoDLunchOrderModels");
        }
    }
}
