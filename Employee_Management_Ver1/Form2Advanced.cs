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
    public partial class Form2Advanced : Form
    {
        public Form2Advanced()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //point to Form1Advanced
            Form1Advanced form = new Form1Advanced();

            //dont use 
            //form.customerName = textBox1.Text;
            //form.lastName = textBox2.Text;
            //form.Address = textBox3.Text;
            //form.City = textBox4.Text;
            //form.Product = textBox5.Text;

            //not sure if this code below works or breaks the app
            //form.CustomerName = name;
            //form.Email = email;
            //form.Product = product;
            //form.Costs = costs.ToString();
            //form.ID = id;

            //this works
            form.CustomerName = textBox1.Text;
            form.Email = textBox2.Text;
            form.Product = textBox3.Text;
            form.Costs = textBox4.Text;
            form.ID = textBox5.Text;
            form.ShowDialog();
        }
    }
}
