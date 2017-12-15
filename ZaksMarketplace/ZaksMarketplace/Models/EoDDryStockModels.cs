using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class EoDDryStockModels
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        [Display(Name = "Diet Coke")]
        public int DietCoke { get; set; }
        [Display(Name = "Coke")]
        public int Coke { get; set; }
        [Display(Name = "Sprite")]
        public int Sprite { get; set; }
        [Display(Name = "Chewy Bar")]
        public int ChewyBar { get; set; }
        [Display(Name = "Water")]
        public int Water { get; set; }
        [Display(Name = "Cup Sleeves")]
        public int CupSleeve { get; set; }
        [Display(Name = "Cup Packs")]
        public int CupPack { get; set; }
        [Display(Name = "Cup Lid packs")]
        public int CupLid { get; set; }
        [Display(Name = "Sugar")]
        public int Sugar{ get; set; }
        [Display(Name = "Sugar In The Raw")]
        public int SugarInTheRaw{ get; set; }
        [Display(Name = "Creamer")]
        public int Creamer { get; set; }
        [Display(Name = "Napkins")]
        public int Napkins { get; set; }
        [Display(Name = "Stir Sticks")]
        public int StirSicks { get; set; }
        [Display(Name = "Chips")]
        public int Chips { get; set; }
        [Display(Name = "Coffee Filter Packs")]
        public int CoffeeFilter { get; set; }
        [Display(Name = "Candy")]
        public int Candy { get; set; }



    }
}