using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    //Lista con los diferentes estados de la orden
    public class OrderStatus
    {
        [key]
        public int OrderStatusID { get; set; }

    }
}