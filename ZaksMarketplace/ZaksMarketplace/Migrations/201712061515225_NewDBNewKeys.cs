namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDBNewKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EoDDryStockModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        DietCoke = c.Int(nullable: false),
                        Coke = c.Int(nullable: false),
                        Sprite = c.Int(nullable: false),
                        ChewyBar = c.Int(nullable: false),
                        Water = c.Int(nullable: false),
                        CupSleeve = c.Int(nullable: false),
                        CupPack = c.Int(nullable: false),
                        CupLid = c.Int(nullable: false),
                        Sugar = c.Int(nullable: false),
                        SugarInTheRaw = c.Int(nullable: false),
                        Creamer = c.Int(nullable: false),
                        Napkins = c.Int(nullable: false),
                        StirSicks = c.Int(nullable: false),
                        Chips = c.Int(nullable: false),
                        CoffeeFilter = c.Int(nullable: false),
                        Candy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EoDLunchModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
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
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.EoDLunchModels");
            DropTable("dbo.EoDDryStockModels");
        }
    }
}
