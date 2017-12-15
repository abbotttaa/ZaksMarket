namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestAgain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CateringInvoiceModels",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        DatePlaced = c.String(),
                        DateRequested = c.String(),
                        Cost = c.Double(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.CateringMenuModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        PotatoChips = c.Int(nullable: false),
                        SweetpotatoChips = c.Int(nullable: false),
                        Frys = c.Int(nullable: false),
                        VeggieMix = c.Int(nullable: false),
                        Coke = c.Int(nullable: false),
                        DietCoke = c.Int(nullable: false),
                        Sprite = c.Int(nullable: false),
                        Rootbeer = c.Int(nullable: false),
                        MountainDew = c.Int(nullable: false),
                        DrPepper = c.Int(nullable: false),
                        DietSprite = c.Int(nullable: false),
                        SmallHorderves = c.Int(nullable: false),
                        MediumHorderves = c.Int(nullable: false),
                        LargeHorderves = c.Int(nullable: false),
                        PotatoSalad = c.Int(nullable: false),
                        TacoPlatter = c.Int(nullable: false),
                        VegiesDip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CateringMenuModels");
            DropTable("dbo.CateringInvoiceModels");
        }
    }
}
