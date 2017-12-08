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
        [ForeignKey("CustomCaterOrderNumber")]
        public virtual CateringJuctModels Id { get; set; }
        //Core
        public int ChefSalad { get; set; }
        public int CranSalad { get; set; }
        public int CaeserSalad { get; set; }
        public int RanchDressingCup { get; set; }
        public int BalsamicDressingCup { get; set; }
        public int Tuna { get; set; }
        public int ChickenSaladSam { get; set; }
        public int ColdItalian { get; set; }
        public int BuffaloRanch { get; set; }
        public int BuffaloBleu { get; set; }
        public int TurkeyClub { get; set; }
        public int BLTCClub { get; set; }
        public int PortabelloWrap { get; set; }
        public int GrilledCheese { get; set; }
        public int TurkeyApple { get; set; }
        public int HamCheese { get; set; }
        public int BLTCWrap { get; set; }
        //Chips
        public int PotatoChips {get; set;}
        public int SweetpotatoChips {get; set;}
        public int Frys {get; set;}
        public int VeggieMix {get; set;}
        //Drinks
        public int Coke {get; set;}
        public int DietCoke {get; set;}
        public int Sprite {get; set;}
        public int Rootbeer {get; set;}
        public int MountainDew {get; set;}
        public int DrPepper {get; set;}
        public int DietSprite {get; set;}
        //Platters / Meals
        public int SmallHorderves { get; set;}
        public int MediumHorderves { get; set;}
        public int LargeHorderves { get; set;}
        public int PotatoSalad {get; set;}
        public int TacoPlatter {get; set;}
        public int VegiesDip {get; set;}
    }
}