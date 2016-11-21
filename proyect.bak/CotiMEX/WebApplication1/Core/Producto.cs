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

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public byte[] getImg()
        {
            return this.img;
        }

        public void setImg(byte[] img)
        {
            this.img = img;
        }

        public Type getType()
        {
            return this.type;
        }

        public void setType(Type type)
        {
            this.type = type;
        }
        //Nested enum so you can't select a type different from the permited ones
        public enum Type : int
        {
            RENT = 2,
            SELL = 1
        }
    }
}