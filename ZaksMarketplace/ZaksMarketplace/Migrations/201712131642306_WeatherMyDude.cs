namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeatherMyDude : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EoDLunchModels", "DaysWeather", c => c.String());
            AddColumn("dbo.EoDLunchOrderModels", "TomorrowsWeather", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EoDLunchOrderModels", "TomorrowsWeather");
            DropColumn("dbo.EoDLunchModels", "DaysWeather");
        }
    }
}
