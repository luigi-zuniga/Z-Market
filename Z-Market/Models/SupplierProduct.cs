using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }

        //Este seria el lado Varios o Muchos en la Relacion
        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }

    }
}