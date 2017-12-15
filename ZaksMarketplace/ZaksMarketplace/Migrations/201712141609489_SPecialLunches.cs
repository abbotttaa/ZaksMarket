namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SPecialLunches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpeacialLunchModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeaturedChoice = c.String(),
                        Cost = c.String(),
                        DateOffered = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SpeacialLunchModels");
        }
    }
}
