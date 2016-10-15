using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Core
{
    public class Producto
    {

        //Id of the product
        public virtual int id { get; set; }

        // Name of the prouct
        public virtual string name { get; set; }

        //price of the product
        public virtual double price { get; set; }

        // byte array for image file
        public virtual byte[] img { get; set; }

        //is it for sale or for rent
        public virtual Type type { get; set; }

        //Nested enum so you can't select a type different from the permited ones
        public enum Type : int
        {
            RENT = 2,
            SELL = 1
        }
    }
}