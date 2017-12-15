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
        public string Date { get; set; }
        [Display(Name = "Regular Coffee")]
        public int RegularCoffee { get; set; }
        [Display(Name = "Decaf Coffee")]
        public int DecafCoffee { get; set; }
        [Display(Name = "Latte")]
        public int Latte { get; set; }

        public int DayOfWeek { get; set; }
    }
}