using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class EoDLunchModels
    {
        [Key]
        public int Date { get; set; }
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


    }
}