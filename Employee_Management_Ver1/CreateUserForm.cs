using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Ver1
{
    public partial class CreateUserForm : Form
    {
        private bool IsManager { get; set; }
        public CreateUserForm(bool isManager)
        {
            InitializeComponent();
            IsManager = isManager;

            if (IsManager)
            {
                btnVerify.Enabled = false;
            }
            else {
                txtPassword.Enabled = false;
                txtRePassword.Enabled = false;
                btnCreateCred.Enabled = false;
            }
        }

        private void btnCreateCred_Click(object sender, EventArgs e)
        {
            // Create your regex pattern
            string pattern = @"\S{6,}$";
            // Create your regex object using the pattern
            Regex rg = new Regex(pattern);

            if (txtPassword.Text == txtRePassword.Text && rg.IsMatch(txtPassword.Text)){
                if (!IsManager)
                {
                    if (FileHandler.AddEmployeeCred(new EmployeeCred(txtUsername.Text, txtPassword.Text)))
                    {
                        MessageBox.Show("Employee Credential Created!");
                    }
                    else
                    {
                        MessageBox.Show("This Employee already have credential!");
                    }
                }
                else {
                    if (FileHandler.WriteToTextFile(new User(txtUsername.Text, txtPassword.Text)))
                    {
                        MessageBox.Show("Manager Credential Created!");
                    }
                    else
                    {
                        MessageBox.Show("This Manager already have credential!");
                    }
                }
                this.Close();
            }
            else {
                MessageBox.Show("Passwords must be the same, no space and at least size 6.");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (FileHandler.GetEmployee(txtUsername.Text) != null)
            {
                btnVerify.Text = "";
                btnVerify.Enabled = false;
                btnVerify.BackColor = Color.Transparent;
                btnVerify.FlatStyle = FlatStyle.Flat;
                btnVerify.FlatAppearance.BorderSize = 0;
                btnVerify.BackgroundImage = System.Drawing.Image.FromFile(@"../../../source/verified.jpg");
                btnVerify.BackgroundImageLayout = ImageLayout.Zoom;
                txtUsername.Enabled = false;
                txtPassword.Enabled = true;
                txtRePassword.Enabled = true;
                btnCreateCred.Enabled = true;
                txtPassword.Focus();
            }
            else {
                MessageBox.Show("Employee not Found!");
            }
            
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void CreateUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
