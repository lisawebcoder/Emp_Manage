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
    public partial class Form1Advanced : Form
    {
        //fields or properties? not sure
        //public string customerName { get; set; }
        //public string lastName { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string Product { get; set; }



        //new
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Costs { get; set; }
        public string Product { get; set; }


        public Form1Advanced()
        {
            InitializeComponent();
        }

        private void Form1Advanced_Load(object sender, EventArgs e)
        {
            //i double clicked the form itself 
            //to create this load event block
            //create the label1 to label5 and its properties fields
            //label1.Text = customerName;
            //label2.Text = lastName;
            //label3.Text = Address;
            //label4.Text = City;
            //label5.Text = Product;
            
            //april 25th 2022
            txtName.Text = CustomerName;
            txtEmail.Text = Email;
            txtID.Text = ID;
            txtCosts.Text = Costs;
            txtProduct.Text = Product;

        }
        //new
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
