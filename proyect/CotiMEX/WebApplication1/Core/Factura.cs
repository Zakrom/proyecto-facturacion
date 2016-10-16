using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Core
{
    public class Factura
    {

        //Id of the receipt 
        public int id;

        // Product of the receipt
        public List<Producto> products;

        //price of the product
        public DateTime startingDate;

        //total to pay in the receipt
        public double total;

        //recepits owner
        public Cliente cliente;


        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public List<Producto> getProducts()
        {
            return this.products;
        }

        public void setProducts(List<Producto> products)
        {
            this.products = products;
        }

        public DateTime getStartingDate()
        {
            return this.startingDate;
        }

        public void setStartingDate(DateTime startingDate)
        {
            this.startingDate = startingDate;
        }

        public double getTotal()
        {
            return this.total;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

        public Cliente getClient()
        {
            return cliente;
        }

        public void setClient(Cliente client)
        {
            this.cliente = client;
        }

    }
}