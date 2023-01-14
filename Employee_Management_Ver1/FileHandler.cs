using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Employee_Management_Ver1
{
    static class FileHandler
    {
        
        private static string binFilePath = @"../../../data/employees.bin";
        private static string textFilePath = @"../../../data/users.txt";
        private static string xmlFilePath = @"../../../data/employeesCred.xml";
        //april 18th 2022
        private static string binFilePath2 = @"../../../data/customers.bin";
        //april 19th 2022
        //private static string textFilePath2 = @"../../../data/users2.txt";

        //employee
        public static void WriteToBinFile(List<Employee> myEmployeeList) {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();

            //Serialize
            writer.Serialize(fs, myEmployeeList);

            fs.Close();
        }


        //april 18th 2022
        public static void WriteToBinFile2(List<Customer>myCustomerList)
        {
            FileStream fs2 = new FileStream(binFilePath2, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();

            //Serialize
            writer.Serialize(fs2, myCustomerList);

            fs2.Close();
        }



        //employee
        public static List<Employee> ReadFromBinFile() {
            List<Employee> tempListOfEmployee = new List<Employee>();

            if (File.Exists(binFilePath)) {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter reader = new BinaryFormatter();

                tempListOfEmployee = (List<Employee>)reader.Deserialize(fs);

                fs.Close();
            }

            return tempListOfEmployee;
        }


        //april 18th 2022
        public static List<Customer> ReadFromBinFile2()
        {
            List<Customer> tempListOfCustomer = new List<Customer>();

            if (File.Exists(binFilePath2))
            {
                FileStream fs2 = new FileStream(binFilePath2, FileMode.Open, FileAccess.Read);
                BinaryFormatter reader = new BinaryFormatter();

                tempListOfCustomer = (List<Customer>)reader.Deserialize(fs2);

                fs2.Close();
            }

            return tempListOfCustomer;
        }




        //employee
        public static Employee GetEmployee(string email) {
            //this is the same of do a foreach and check if email is equal to the current element
            //return ReadFromBinFile().Find(employee => employee.Email == email);
            foreach (Employee employee in ReadFromBinFile())
            {
                if (employee.Email.ToUpper() == email.ToUpper()) {
                    return employee;
                }
            }
            return null;            
        }


        //april 18th 2022
        public static Customer GetCustomer(string email)
        {
            //this is the same of do a foreach and check if email is equal to the current element
            //return ReadFromBinFile2().Find(customer => customer.Email == email);
            foreach (Customer customer in ReadFromBinFile2())
            {
                if (customer.Email.ToUpper() == email.ToUpper())
                {
                    return customer;
                }
            }
            return null;
        }




        // WORK WITH TEXT FILE

        public static void WriteToTextFile(List<User> myUsers) {
            using (StreamWriter writer = File.CreateText(textFilePath)) {
                foreach (User user in myUsers)
                {
                    writer.WriteLine(user.Username + "|" + user.Password);
                }

            }
        }


        //april 19th 2022:customer from user
        //public static void WriteToCustomerTextFile(List<User> myCusts)
        //{
        //    using (StreamWriter writer = File.CreateText(textFilePath2))
        //    {
        //        foreach (User cust in myCusts)
        //        {
        //            writer.WriteLine(cust.Username + "|" + cust.Password);
        //        }
        //    }
        //}


        public static bool WriteToTextFile(User user) {
            List<User> tempUsers = ReadFromTextFile();
            if (!File.Exists(textFilePath))
            {
                using (StreamWriter writer = File.CreateText(textFilePath))
                {
                    writer.WriteLine(user.Username + "|" + user.Password);
                    return true;
                }
            }
            else {
                using (StreamWriter writer = File.AppendText(textFilePath))
                {
                    foreach (User usr in tempUsers)
                    {
                        if (usr.Username.ToUpper() == user.Username.ToUpper()) {
                            return false;
                        }
                    }
                    writer.WriteLine(user.Username + "|" + user.Password);
                    return true;
                }
            }
        }

        public static List<User> ReadFromTextFile() {
            StreamReader reader = new StreamReader(textFilePath);
            string textLine = null;
            List<User> tempUsers = new List<User>();

            while ((textLine = reader.ReadLine()) != null) {
                string[] userData = textLine.Split('|');
                tempUsers.Add(new User(userData[0], userData[1]));
            }
            reader.Close();

            return tempUsers;
        }

        public static bool Login(string username, string password) {
            //int index = ReadFromTextFile().FindIndex(user => user.Username == username && user.Password == password);
            // return index<0 ? false : true;
            foreach (User user in ReadFromTextFile())
            {
                if (user.Username == username && user.Password == password) {
                    return true;
                }
            }
            return false; 
        }

        //WORK WITH XML FILE

        public static void WriteToXmlFile(List<EmployeeCred> myEmployeeCreds) {
            XmlWriter writer = XmlWriter.Create(xmlFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeCred>));
            serializer.Serialize(writer, myEmployeeCreds);
            writer.Close();
        }

        public static List<EmployeeCred> ReadFromXmlFile() {
            List<EmployeeCred> myTempEmployeeCred = new List<EmployeeCred>();
            XmlSerializer deserializer = new XmlSerializer(typeof(List<EmployeeCred>));

            if (File.Exists(xmlFilePath)) {
                StreamReader reader = new StreamReader(xmlFilePath);
                myTempEmployeeCred = (List<EmployeeCred>)deserializer.Deserialize(reader);
                reader.Close();
            }

            return myTempEmployeeCred;
        }

        public static bool AddEmployeeCred(EmployeeCred empCred) {
            List<EmployeeCred> tempList = ReadFromXmlFile();
            foreach (EmployeeCred employee in tempList)
            {
                if (employee.Email.ToUpper() == empCred.Email.ToUpper()) {
                    return false;
                }
            }
            tempList.Add(empCred);
            WriteToXmlFile(tempList);
            return true;
        }

        public static bool LoginEmployee(string username, string password) {
            foreach (EmployeeCred empCred in ReadFromXmlFile())
            {
                if (empCred.Email.ToUpper() == username.ToUpper() && empCred.Password == password) {
                    return true;
                }
            }
            return false;
        }
    }
}
