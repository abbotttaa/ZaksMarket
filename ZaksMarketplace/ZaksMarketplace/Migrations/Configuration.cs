namespace ZaksMarketplace.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZaksMarketplace.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZaksMarketplace.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZaksMarketplace.Models.ApplicationDbContext context)
        {
            Random random = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int randomNumber1 = random.Next(1, 5);
                int randomNumber2 = random.Next(1, 5);
                int randomNumber3 = random.Next(1, 7);
                int IdTicker = i;
                context.CoffeeModels.AddOrUpdate(
                    x => x.Id,
                new CoffeeModels()
                {
                    Id = i,
                    Date = "12/08/2017",
                    DecafCoffee = randomNumber1,
                    Latte = randomNumber2,
                    RegularCoffee = randomNumber3,
                    DayOfWeek = 0,
                }
                );
            }

            for (int i = 1; i <= 20; i++)
            {
                int IdTicker = i;
                int randomDressing = random.Next(0, 4);
                int Sammies1 = random.Next(0, 3);
                int Sammies2 = random.Next(0, 3);
                int Sammies3 = random.Next(0, 3);
                int Sammies4 = random.Next(0, 3);
                int Sammies5 = random.Next(0, 3);
                int Sammies6 = random.Next(0, 3);
                int Sammies7 = random.Next(0, 3);
                int Sammies8 = random.Next(0, 3);
                int Sammies9 = random.Next(0, 3);
                int Sammies10 = random.Next(0, 3);
                int Sammies = random.Next(0, 3);
                int buffalo = random.Next(0, 4);
                int buffalo2 = random.Next(0, 4);
                int salad1 = random.Next(0, 2);
                int salad2 = random.Next(0, 2);
                int salad3 = random.Next(0, 2);
                context.EoDLunchModels.AddOrUpdate(
                    x => x.Id,
                new EoDLunchModels()
                {
                    Id = i,
                    BalsamicDressingCup = randomDressing,
                    BLTCClub = Sammies1,
                    BLTCWrap = Sammies2,
                    BuffaloBleu = buffalo,
                    BuffaloRanch = buffalo2,
                    CaeserSalad = salad1,
                    ChefSalad = salad2,
                    ChickenSaladSam = Sammies3,
                    ColdItalian = Sammies4,
                    CranSalad = salad3,
                    Date = "12/08/2017",
                    DaysWeather = "Snow",
                    GrilledCheese = Sammies5,
                    HamCheese = Sammies6,
                    PortabelloWrap = Sammies7,
                    RanchDressingCup = randomDressing,
                    Tuna = Sammies8,
                    TurkeyApple = Sammies9,
                    TurkeyClub = Sammies10,
                    DayOfWeek = 0,
                }
                );
            }
            for (int i = 1; i <= 20; i++)
            {
                int IdTicker = i;
                int randomDressing = random.Next(0, 4);
                int Sammies1 = random.Next(0, 3);
                int Sammies2 = random.Next(0, 3);
                int Sammies3 = random.Next(0, 3);
                int Sammies4 = random.Next(0, 3);
                int Sammies5 = random.Next(0, 3);
                int Sammies6 = random.Next(0, 3);
                int Sammies7 = random.Next(0, 3);
                int Sammies8 = random.Next(0, 3);
                int Sammies9 = random.Next(0, 3);
                int Sammies10 = random.Next(0, 3);
                int Sammies = random.Next(0, 3);
                int buffalo = random.Next(0, 4);
                int buffalo2 = random.Next(0, 4);
                int salad1 = random.Next(0, 2);
                int salad2 = random.Next(0, 2);
                int salad3 = random.Next(0, 2);
                context.Lunch.AddOrUpdate(
                    x => x.Id,
                    new EoDLunchOrderModels()
                    {
                        Id = i,
                        BalsamicDressingCup = randomDressing,
                        BLTCClub = Sammies1,
                        BLTCWrap = Sammies2,
                        BuffaloBleu = buffalo,
                        BuffaloRanch = buffalo2,
                        CaeserSalad = salad1,
                        ChefSalad = salad2,
                        ChickenSaladSam = Sammies3,
                        ColdItalian = Sammies4,
                        CranSalad = salad3,
                        Date = "12/08/2017",
                        TomorrowsWeather = "Snow",
                        GrilledCheese = Sammies5,
                        HamCheese = Sammies6,
                        PortabelloWrap = Sammies7,
                        RanchDressingCup = randomDressing,
                        Tuna = Sammies8,
                        TurkeyApple = Sammies9,
                        TurkeyClub = Sammies10,
                        DayOfWeek = 0,
                    }
                    );
            }

        }

    }
}
