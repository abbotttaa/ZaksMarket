using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class EoDLunchOrderModels
    {
        [Key]
        public int Id { get; set; }

        public string TomorrowsWeather { get; set; }
        public string Date { get; set; }
        [Display(Name = "CHef Salad")]
        public int ChefSalad { get; set; }
        [Display(Name = "Cran Salad")]
        public int CranSalad { get; set; }
        [Display(Name = "Caeser salad")]
        public int CaeserSalad { get; set; }
        [Display(Name = "Side Ranch Dressing")]
        public int RanchDressingCup { get; set; }
        [Display(Name = "Side Balsamic Dressing")]
        public int BalsamicDressingCup { get; set; }
        [Display(Name = "Tuna")]
        public int Tuna { get; set; }
        [Display(Name = "Chicken salad")]
        public int ChickenSaladSam { get; set; }
        [Display(Name = "Cold Italian")]
        public int ColdItalian { get; set; }
        [Display(Name = "Buffalo Ranch")]
        public int BuffaloRanch { get; set; }
        [Display(Name = "Buffalo Bleu")]
        public int BuffaloBleu { get; set; }
        [Display(Name = "Turkey Club")]
        public int TurkeyClub { get; set; }
        [Display(Name = "BLTC Club")]
        public int BLTCClub { get; set; }
        [Display(Name = "Portabello Wrap")]
        public int PortabelloWrap { get; set; }
        [Display(Name = "Grilled Cheese")]
        public int GrilledCheese { get; set; }
        [Display(Name = "turkey apple")]
        public int TurkeyApple { get; set; }
        [Display(Name = "Ham Cheese")]
        public int HamCheese { get; set; }
        [Display(Name = "BLTC Wrap")]
        public int BLTCWrap { get; set; }

        public int DayOfWeek { get; set; }
    }
}