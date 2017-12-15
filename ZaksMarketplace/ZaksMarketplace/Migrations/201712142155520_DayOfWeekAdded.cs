namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DayOfWeekAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoffeeModels", "DayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.EoDLunchModels", "DayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.EoDLunchOrderModels", "DayOfWeek", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EoDLunchOrderModels", "DayOfWeek");
            DropColumn("dbo.EoDLunchModels", "DayOfWeek");
            DropColumn("dbo.CoffeeModels", "DayOfWeek");
        }
    }
}
