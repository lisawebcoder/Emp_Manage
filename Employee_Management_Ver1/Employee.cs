using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Ver1
{
    [Serializable]
    class Employee:IHumanResource
    {
        string id;
        string email;
        string name;
        string department;
        double comission;
        double baseSalary;
        double lastAmountSold;
        //april 18th 2022
        //double costs;
        //double basePrice;
        //double amountSold;

        //april 18th 2022 added 3 more parms
        //, double costs, double basePrice, double amountSold
        public Employee(string id, string email, string name, string department, double comission, double baseSalary, double lastAmountSold)
        {
            this.id = id;
            this.email = email;
            this.name = name;
            this.department = department;
            this.comission = comission;
            this.baseSalary = baseSalary;
            this.lastAmountSold = lastAmountSold;
            //april 18th 2022
            //this.costs = costs;
            //this.basePrice = basePrice;
            //this.amountSold = amountSold;
        }

        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public double Comission { get => comission; set => comission = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        public double LastAmountSold { get => lastAmountSold; set => lastAmountSold = value; }
        //april 18th 2022
        //public double Costs { get => costs; set => costs = value; }
        //public double BasePrice { get => basePrice; set => basePrice = value; }
        //public double AmountSold { get => AmountSold; set => AmountSold = value; }

        public double Salary()
        {
            return BaseSalary + (Comission * LastAmountSold);
        }
        //april 18th 2022
        //public double Price()
        //{
        //    return BasePrice + (Costs * AmountSold);
        //}

        public override string ToString()
        {
            return Id + "    " + Name + "          " + Email + "             " + Department + "                " + Salary();
        }

        //public override string ToString()
        //{
        //    return Id + "    " + Name + "          " + Email + "             " + Product + "                " + Price();
        //}
    }
}
