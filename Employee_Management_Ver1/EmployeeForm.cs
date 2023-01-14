using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Ver1
{
    public partial class EmployeeForm : Form
    {
        //Retrieve data from file
        List<Employee> myListEmployees = FileHandler.ReadFromBinFile();
        private string originalUsername;

        public EmployeeForm(string username)
        {
            InitializeComponent();
            originalUsername = username;            
            cbDepartment.Items.Add("FINANCE");
            cbDepartment.Items.Add("MARKETING");
            cbDepartment.Items.Add("RH");
            cbDepartment.Items.Add("PRODUCTION");
            //april 18th 2022
            cbDepartment.SelectedIndex = 0;


            foreach (var employee in myListEmployees)
            {
                if(username == employee.Email)
                {
                    //fetch textbox and display
                    txtName.Text = employee.Name;
                    cbDepartment.Text = employee.Department;
                    //break foreach
                    break;
                }

            }

            
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            foreach (var employee in myListEmployees)
            {
                if (originalUsername == employee.Email)
                {
                    //input textbox and store to bin
                    employee.Name = txtName.Text;
                    employee.Department = cbDepartment.Text;
                    
                    //break foreach
                    break;
                }
            }

            //write
            FileHandler.WriteToBinFile(myListEmployees);
            MessageBox.Show("Employee info updated!");
            //this closes the account window after update
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //april 18th 2022
            //point to FormAdvanced3
            FormAdvanced3 form3 = new FormAdvanced3();            
            form3.ShowDialog();
            //  you cant access the back window
            //and when you close the front window
            //it closes the back too
            this.Close();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            //april 25th 2022
            btnUpdate.Focus();

        }
    }
}
