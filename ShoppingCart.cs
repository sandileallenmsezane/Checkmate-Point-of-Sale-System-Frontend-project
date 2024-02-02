using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectM4
{
    public class ShoppingCart
    {
       public int Prod_Id { get; set; }

      public  String Prod_Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal SubTotal { get; set; }


    }
}