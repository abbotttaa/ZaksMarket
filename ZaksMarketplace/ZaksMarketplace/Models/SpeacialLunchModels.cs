using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class SpeacialLunchModels
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Featured Choice")]
        public string FeaturedChoice { get; set; }

        public string Cost { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Offered")]
        public string DateOffered { get; set; }
    }
}