using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAT_Hub.Models
{
    public class Item
    {
        public string description { get; set; }
        public string uom { get; set; }
        public int unit { get; set; }
        public decimal amount { get; set; }
        public decimal vatAmount { get; set; }
        public bool isVatable { get; set; }
    }
}