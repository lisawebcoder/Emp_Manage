using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Ver1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            isManager.Checked = true;
            List<User> myUsers = new List<User>();
            myUsers.Add(new User("renan", "123"));
            myUsers.Add(new User("john", "123"));
            myUsers.Add(new User("elon", "spaceX"));
            FileHandler.WriteToTextFile(myUsers);
        }
        //april 1st 2022 me
        //this method code takes you to the form grid page
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isManager.Checked == true)
            {
                if (FileHandler.Login(txtUsername.Text, txtPassword.Text))
                {
                    //april 1st 2022 me
                    //should we comment hide? since we have showdialog
                    this.Hide();
                    Form1 main = new Form1();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    txtError.Text = "INVALID USERNAME OR PASSWORD!";
                    SystemSounds.Exclamation.Play();
                }
            }
            else {
                if (FileHandler.LoginEmployee(txtUsername.Text, txtPassword.Text))
                {
                    //MessageBox.Show("EMPLOYEE LOGGED!");
                    //april 1st 2022 me
                    //should we comment hide? since we have showdialog
                    //we need a new form
                    //this.Hide();
                    EmployeeForm eForm = new EmployeeForm(txtUsername.Text);
                    eForm.ShowDialog();
                    //this.Close();
                }
                else {
                    txtError.Text = "INVALID USERNAME OR PASSWORD!";
                    SystemSounds.Exclamation.Play();
                }
            }
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCred_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserForm createUser = new CreateUserForm(isManager.Checked);
            createUser.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //point to form2advanced           
            Form2Advanced form = new Form2Advanced();            
            form.ShowDialog();
        }
    }
}
