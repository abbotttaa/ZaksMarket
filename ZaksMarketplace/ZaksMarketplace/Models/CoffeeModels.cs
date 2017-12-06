using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class CoffeeModels
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int RegularCoffee { get; set; }
        public int DecafCoffee { get; set; }
        public int Latte { get; set; }
    }
}