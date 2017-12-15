using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class CateringMenuModels
    {
        public int Id { get; set; }
        //Core
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
        //Chips
        [Display(Name = "Potato CHips")]
        
        public int PotatoChips {get; set;}
        [Display(Name = "Sweet Potato Chips")]
        public int SweetpotatoChips {get; set;}
        [Display(Name = "Frys")]
        public int Frys {get; set;}
        [Display(Name = "Veggie Mix")]
        public int VeggieMix {get; set;}
        
        //Drinks
        public int Coke {get; set;}
        [Display(Name = "Diet Coke")]
        public int DietCoke {get; set;}
      
        public int Sprite {get; set;}
       
        public int Rootbeer {get; set;}
        
        public int MountainDew {get; set;}
        
        public int DrPepper {get; set;}
        [Display(Name = "Diet Sprite")]
        public int DietSprite {get; set;}
        [Display(Name = "Email")]
        //Platters / Meals
        public int SmallHorderves { get; set;}
        [Display(Name = "Medium Seasonal Horderves")]
        public int MediumHorderves { get; set;}
        [Display(Name = "Large Seasonal Horderves")]
        public int LargeHorderves { get; set;}
        [Display(Name = "Potato Salad")]
        public int PotatoSalad {get; set;}
        [Display(Name = "Taco Platter")]
        public int TacoPlatter {get; set;}
        [Display(Name = "Veggie Dip")]
        public int VegiesDip {get; set;}
        
    }
}