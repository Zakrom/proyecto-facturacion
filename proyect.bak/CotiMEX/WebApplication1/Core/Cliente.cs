using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Core
{
    public class Cliente
    {

        public int id;

        public string name;

        public string phoneNumber;

        public string email;

        public string business;

        public string address;

        public string rfc;

        public List<Factura> facturas;

        public User user;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setStartingDate(string name)
        {
            this.name = name;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        
        public string getemail()
        {
            return this.email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public string getBusiness()
        {
            return this.business;
        }

        public void setBusiness(string business)
        {
            this.business = business;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getRfc()
        {
            return this.rfc;
        }

        public void setRfc(string rfc)
        {
            this.rfc = rfc;
        }

        public List<Factura> getFacturas()
        {
            return this.facturas;
        }

        public void setFacturas(List<Factura> facturas)
        {
            this.facturas = facturas;
        }

        public User getUser()
        {
            return this.user;
        }

        public void setUser(User user)
        {
            this.user = user;
        }
    }
}