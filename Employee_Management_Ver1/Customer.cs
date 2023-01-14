using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Ver1
{
    [Serializable]
    internal class Customer : ICustomerResource
    {
        //april 18th 2022
        string id;
        string email;
        string name;
        string product;
        double costs;
        double basePrice;
        double amountSold;


        //april 18th 2022 added 7 more parms
        //, double costs, double basePrice, double amountSold
        //string id, string email, string name, string product,
        public Customer(string id, string email, string name, string product, double costs, double basePrice, double amountSold)
        {

            //april 18th 2022
            this.id = id;
            this.email = email;
            this.name = name;
            this.product = product;
            this.costs = costs;
            this.basePrice = basePrice;
            this.amountSold = amountSold;
        }


        //april 18th 2022
        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Product { get => product; set => product = value; }
        public double Costs { get => costs; set => costs = value; }
        public double BasePrice { get => basePrice; set => basePrice = value; }
        public double AmountSold { get => amountSold; set => amountSold = value; }
        


        //april 18th 2022
        public double Price()
        {
            return BasePrice + (Costs * AmountSold);
        }

        //april 18th 2022

        public override string ToString()
        {
            return Id + "    " + Name + "          " + Email + "             " + Product + "                " + Price();
        }




    }
}
