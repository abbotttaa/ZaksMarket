﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class CateringJuctModels
    {
        [Key]
        public int JunctId { get; set; }

        public int InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public virtual CateringInvoiceModels Invoices { get; set; }

        public int CustomCaterOrderNumber { get; set; }

        
    }
}