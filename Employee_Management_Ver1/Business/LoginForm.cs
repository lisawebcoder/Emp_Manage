using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Ver1.Business
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //i am trying to point to my main login form
        private void button1_Click(object sender, EventArgs e)
        {
            //point to Form1Advanced
            Login form = new Login();
            form.ShowDialog();
            //  you cant access the back window
            //and when you close the front window
            //it closes the back too
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //point to Form1Advanced
            Login form = new Login();
            form.ShowDialog();
            //  you cant access the back window
            //and when you close the front window
            //it closes the back too
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //point to Form1Advanced
            Login form = new Login();
            form.ShowDialog();
            //  you cant access the back window
            //and when you close the front window
            //it closes the back too
            this.Close();
        }
    }
}
