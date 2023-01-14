using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Ver1
{
    [Serializable]
    public class EmployeeCred
    {
        public EmployeeCred(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public EmployeeCred()
        {
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
