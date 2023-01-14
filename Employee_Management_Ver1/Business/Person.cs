using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Ver1.Business
{
    internal class Person
    {

        //constructor
        public Person(string examusername,string exampassword,string examName, string examWork)
        {
            ExamName = examName;
            ExamWork = examWork;
            ExamUsername = examusername;
            ExamPassword = exampassword;
        }
        //properties
        public string ExamName { get; set; }
        public string ExamWork { get; set; }    

        public string ExamUsername { get; set; }
        public string ExamPassword { get; set; }

    }
}
