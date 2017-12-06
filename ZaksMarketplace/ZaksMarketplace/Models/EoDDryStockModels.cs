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
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int DietCoke { get; set; }
        public int Coke { get; set; }
        public int Sprite { get; set; }
        public int ChewyBar { get; set; }
        public int Water { get; set; }
        public int CupSleeve { get; set; }
        public int CupPack { get; set; }
        public int CupLid { get; set; }
        public int Sugar{ get; set; }
        public int SugarInTheRaw{ get; set; }
        public int Creamer { get; set; }
        public int Napkins { get; set; }
        public int StirSicks { get; set; }
        public int Chips { get; set; }
        public int CoffeeFilter { get; set; }
        public int Candy { get; set; }



    }
}