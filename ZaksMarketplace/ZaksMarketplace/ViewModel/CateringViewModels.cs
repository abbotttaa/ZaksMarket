using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZaksMarketplace.Models
{
    public class CateringViewModels
    {
        public CateringInvoiceModels Invoice { get; set; }

        public CateringJuctModels Junction { get; set; }

        public CateringMenuModels Menu { get; set; }
    }
}