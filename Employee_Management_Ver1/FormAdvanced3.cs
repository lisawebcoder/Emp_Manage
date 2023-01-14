using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Ver1
{
    public partial class FormAdvanced3 : Form
    {
        //april 18th 2022
        List<Customer> myListCustomers = new List<Customer>();

        public FormAdvanced3()
        {
            InitializeComponent();
            //APRIL 18TH 2022
            cbProduct.Items.Add("TOYS");
            cbProduct.Items.Add("COMPUTERS");
            cbProduct.Items.Add("TV");
            cbProduct.Items.Add("HOME");
            //april 18th 2022
            cbProduct.SelectedIndex = 3;

            //april 18th 2022
            //Retrieve data from file
            myListCustomers = FileHandler.ReadFromBinFile2();
            UpdateGridView2(myListCustomers);

            //april 23rd 2022
            //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
            var source = new BindingSource();
            source.DataSource = myListCustomers;
            gvCustomerBind.DataSource = source;
        }


        //this not working when i click why?
        //april 25th it works ok
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    //test if button work son click
            //    //it does work ; form closes
            //    //so why doesnt bind code work?
            //    //this.Close();

            //    //april 23rd 2022
            //    //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
            //    var source = new BindingSource();
            //    source.DataSource = myListCustomers;
            //    gvCustomerBind.DataSource = source;

            //}
            //catch
            //{
            //    MessageBox.Show("not working why?");
            //}

            //trying thos bind added code cuz w/out it
            //bind doesnt work; so i dotn know if its the 
            //same in week 9 vid; im confused
            //---------------------------------
            string name = textBox3.Text;            
            string email = textBox2.Text;
            string id = textBox4.Text;
            string product = (string)cbProduct.SelectedItem;
            double costs = (double)trackCosts.Value / 100;

            try
            {
                double AmountSold = Convert.ToDouble(txtAmountSold.Text);
                //why did i name the price box textBox1? stupid of me
                double BasePrice = Convert.ToDouble(textBox1.Text);
                // Create a new custopmer
                Customer myCustomer = new Customer(id, email, name, product, costs, BasePrice,AmountSold);
                myListCustomers.Add(myCustomer);
                MessageBox.Show("Customer Task/Order Added!");
                //Write the new list in the file
                FileHandler.WriteToBinFile2(myListCustomers);
                //We read the list and update the grid
                UpdateGridView2(FileHandler.ReadFromBinFile2());
                //we clear the textbox fields
                CleanFields();

                //why are these 3 lines here?
                //myListEmployees.Add(myListEmployees[myListEmployees.Count - 1]);
                //listBoxEmployees.Items.Add(myEmployee.ToString());
                //AddEmployeeToDataGrid(myEmployee);

                //april 19th 2022
                //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
                var source = new BindingSource();
                source.DataSource = myListCustomers;
                gvCustomerBind.DataSource = source;

                //aprul 25th 2022
                //trying to send to form1 to display output
                //point to Form1Advanced
                Form1Advanced form = new Form1Advanced();
                form.CustomerName = name;
                form.Email = email;
                form.Product = product;
                form.Costs = costs.ToString();
                form.ID = id;
                form.ShowDialog();


            }
            catch
            {

                // i need to change this alert? i dont have a validation
                //MessageBox.Show("Amount value must be numbers!");
                MessageBox.Show("error");
            }



            //---------------------------------
        }
        //----------------------------------
        private void CleanFields()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            cbProduct.SelectedIndex = 0;
            trackCosts.Value = 0;
            textBox1.Text = "";
            txtAmountSold.Text = "";
            txtSearch.Text = "";
            textBox4.Focus();
        }
//-------------------------------------------




        //april 19th 2022
        private void UpdateGridView2(List<Customer> myCusts)
        {
            gvCustomer.Rows.Clear();
            foreach (Customer cust in myCusts)
            {
                int index = gvCustomer.Rows.Add();
                gvCustomer.Rows[index].Cells["colId"].Value = cust.Id;
                gvCustomer.Rows[index].Cells["colName"].Value = cust.Name;
                gvCustomer.Rows[index].Cells["colEmail"].Value = cust.Email;
                gvCustomer.Rows[index].Cells["colProduct"].Value = cust.Product;
                gvCustomer.Rows[index].Cells["colPrice"].Value = cust.Price();
            }
        }
        //april 19th 2022
        private void AddCustomerToDataGrid(Customer cust)
        {
            int index = gvCustomer.Rows.Add();
            gvCustomer.Rows[index].Cells["colId"].Value = cust.Id;
            gvCustomer.Rows[index].Cells["colName"].Value = cust.Name;
            gvCustomer.Rows[index].Cells["colEmail"].Value = cust.Email;
            gvCustomer.Rows[index].Cells["colProduct"].Value = cust.Product;
            gvCustomer.Rows[index].Cells["colPrice"].Value = cust.Price();
        }
        //april 25th 2022
        private void trackCosts_ValueChanged(object sender, EventArgs e)
        {
            lblCommission.Text = ((double)trackCosts.Value / 100).ToString();

        }
        //May 1st 2022; i made the search method as per 1st grid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == ""  )
            {
                MessageBox.Show("Type something to search!");
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;

                // temp list to save the customers that match with the search condition
                //List<Employee> tempList = new List<Employee>();
                List<Customer> tempList = new List<Customer>();
                //foreach (Employee emp in myListEmployees)
                foreach (Customer cust in myListCustomers)
                    {
                    //if (emp.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Department.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Email.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Id.ToUpper().Contains(txtSearch.Text.ToUpper()))
                    //if (!(cust.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Product.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Email.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Id.ToUpper().Contains(txtSearch.Text.ToUpper())))
                    if (cust.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Product.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Email.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Id.ToUpper().Contains(txtSearch.Text.ToUpper()))
                    //if (cust.Id.ToUpper().Contains(txtSearch.Text.ToUpper()))
                        {
                        //tempList.Add(emp);
                        tempList.Add(cust);
                        //MessageBox.Show("id is not found!");
                    }
                    //trying to make alert when no id found
                    //IT DOESN NOT WORK IT FREEZES UNLESS LOOP ; FORGET IT
                    //else
                    //{
                    //    //tempList.Add(emp);
                    //    tempList.Add(cust);
                    //    //MessageBox.Show("id is not found!");
                    //}

                    //trying to make alert when no id found
                    //if (!(cust.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Product.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Email.ToUpper().Contains(txtSearch.Text.ToUpper()) || cust.Id.ToUpper().Contains(txtSearch.Text.ToUpper())))
                    //{
                    //    MessageBox.Show("id is not found!");
                    //}

                }
                //UpdateGridView(tempList);
                UpdateGridView2(tempList);
                //May 1st 2022
                btnAdd.Enabled = true;
                CleanFields();
            }
        }
        //May 1st 2022; i added showall method
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            //UpdateGridView(myListEmployees);
            UpdateGridView2(myListCustomers);
            CleanFields();
        }


        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    //april 23rd 2022
        //    //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
        //    var source = new BindingSource();
        //    source.DataSource = myListCustomers;
        //    gvCustomerBind.DataSource = source;
        //}
    }
}
