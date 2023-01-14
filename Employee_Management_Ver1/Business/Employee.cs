using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Ver1.Business
{
    internal class Employee : Person
    {
        //constructor
        public Employee(int examPhoneNumber,string examEmail,string examPosition,string examDegree,string examName, string examWork, string ExamPassword, string ExamUsername) : base(examName, examWork, ExamUsername, ExamPassword)
        {
        }

        //properties
        public string ExamDegree { get; set; }
        public string ExamPosition { get; set;}
        public string ExamEmail { get; set;}

        public int ExamPhoneNumber { get; set; }
    }
}
