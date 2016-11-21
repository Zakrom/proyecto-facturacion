using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Core
{
    public class User
    {
        public int id;

        public string name;

        public string password;

        public double salary;

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

        public void setName(string name)
        {
            this.name = name;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public double getSalary()
        {
            return this.salary;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }
    }
}