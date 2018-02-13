using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Z_Market.Models.ViewModels
{
    public class OrderView
    {
        public Customer Custumer { get; set; }
        public List<ProductOrder> Products { get; set; }
    }
}