using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime DateOrder { get; set; }

        //Relacion con el cliente (Customers)
        public int CustomerID { get; set; }

        public OrderStatus OrderStatus{ get; set; }

        //Una Order le pertenece aun Customer
        public virtual Customer Customer { get; set; }

        //Lado Muchos de 1 Order tiene muchos OrdenDetails <- se pluraliza la relacion muchos
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        //

    }
}