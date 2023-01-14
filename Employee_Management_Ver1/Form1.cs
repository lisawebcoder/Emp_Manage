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
    public partial class Form1 : Form
    {
        List<Employee> myListEmployees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();

            cbDepartment.Items.Add("FINANCE");
            cbDepartment.Items.Add("MARKETING");
            cbDepartment.Items.Add("RH");
            cbDepartment.Items.Add("PRODUCTION");
            cbDepartment.SelectedIndex = 0;

            //Retrieve data from file
            myListEmployees = FileHandler.ReadFromBinFile();
            UpdateGridView(myListEmployees);


            //april 18th 2022
            //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
            var source = new BindingSource();
            source.DataSource = myListEmployees;
            gvEmployeeBind2.DataSource = source;

        }

        private void trackComission_ValueChanged(object sender, EventArgs e)
        {
            lblCommission.Text = ((double)trackComission.Value / 100).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string id = txtId.Text;
            string department = (string)cbDepartment.SelectedItem;
            double commission = (double)trackComission.Value / 100;

            try {
                double lastAmountSold = Convert.ToDouble(txtLastAmountSold.Text);
                double baseSalary = Convert.ToDouble(txtBaseSalary.Text);
                // Create a new employee
                Employee myEmployee = new Employee(id, email, name, department, commission, baseSalary, lastAmountSold);
                myListEmployees.Add(myEmployee);
                MessageBox.Show("Employee Added!");
                //Write the new list in the file
                FileHandler.WriteToBinFile(myListEmployees);
                //We read the list and update the grid
                UpdateGridView(FileHandler.ReadFromBinFile());
                CleanFields();

                //why are these 3 lines here?
                //myListEmployees.Add(myListEmployees[myListEmployees.Count - 1]);
                //listBoxEmployees.Items.Add(myEmployee.ToString());
                //AddEmployeeToDataGrid(myEmployee);

                //april 19th 2022
                //WHAT IS THIS? ITS MESING UP MY CUSTOMER FILE
                var source = new BindingSource();
                source.DataSource = myListEmployees;
                gvEmployeeBind2.DataSource = source;


            }
            catch {
                MessageBox.Show("Amount value must be numbers!");
            }
        }

        private void CleanFields() {
            txtName.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
            cbDepartment.SelectedIndex = 0;
            trackComission.Value = 0;
            txtBaseSalary.Text = "";
            txtLastAmountSold.Text = "";
            txtSearch.Text = "";
            txtId.Focus();
        }

        //Add all the list of employee inside the grid
        private void UpdateGridView(List<Employee> myEmps) {
            gvEmployee.Rows.Clear();
            foreach (Employee emp in myEmps) {
                int index = gvEmployee.Rows.Add();
                gvEmployee.Rows[index].Cells["colId"].Value = emp.Id;
                gvEmployee.Rows[index].Cells["colName"].Value = emp.Name;
                gvEmployee.Rows[index].Cells["colEmail"].Value = emp.Email;
                gvEmployee.Rows[index].Cells["colDepartment"].Value = emp.Department;
                gvEmployee.Rows[index].Cells["colSalary"].Value = emp.Salary();
            }
        }

        //Add a single employee inside the grid
        private void AddEmployeeToDataGrid(Employee emp) {
            int index = gvEmployee.Rows.Add();
            gvEmployee.Rows[index].Cells["colId"].Value = emp.Id;
            gvEmployee.Rows[index].Cells["colName"].Value = emp.Name;
            gvEmployee.Rows[index].Cells["colEmail"].Value = emp.Email;
            gvEmployee.Rows[index].Cells["colDepartment"].Value = emp.Department;
            gvEmployee.Rows[index].Cells["colSalary"].Value = emp.Salary();
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Index Selected Changed: {listBoxEmployees.SelectedIndex}");
            btnEdit.Enabled = true;

            txtName.Text = myListEmployees[listBoxEmployees.SelectedIndex].Name;
            txtEmail.Text = myListEmployees[listBoxEmployees.SelectedIndex].Email;
            txtId.Text = myListEmployees[listBoxEmployees.SelectedIndex].Id;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsLetterOrDigit(e.KeyChar))
            //{
            //    //e.KeyChar = '$';
            //}
            //else {
            //    MessageBox.Show("Invalid Char!");
            //    e.Handled = true;
            //}

            //if (Char.IsLower(e.KeyChar)) {
            //    //string test = e.KeyChar.ToString();
            //    //test = test.ToUpper();
            //    e.KeyChar = Char.ToUpper(e.KeyChar);
            //}

            //if (Char.IsControl(e.KeyChar)) {
            //    MessageBox.Show("Control pressed!");
            //}

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                MessageBox.Show("ID must be only Numbers!");
                e.Handled = true;
            }
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvEmployee.CurrentRow.Index <= myListEmployees.Count - 1) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
                txtId.Enabled = false;
                int index = gvEmployee.CurrentRow.Index;

                txtName.Text = myListEmployees[index].Name;
                txtEmail.Text = myListEmployees[index].Email;
                txtId.Text = myListEmployees[index].Id;
                txtLastAmountSold.Text = myListEmployees[index].LastAmountSold.ToString();
                txtBaseSalary.Text = myListEmployees[index].BaseSalary.ToString();
                cbDepartment.SelectedItem = myListEmployees[index].Department;
                trackComission.Value = Convert.ToInt32(myListEmployees[index].Comission * 100);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtId.Enabled = true;
            int index = gvEmployee.CurrentRow.Index;

            myListEmployees[index].Name = txtName.Text;
            myListEmployees[index].Email = txtEmail.Text;
            myListEmployees[index].LastAmountSold = Convert.ToDouble(txtLastAmountSold.Text);
            myListEmployees[index].BaseSalary = Convert.ToDouble(txtBaseSalary.Text);
            myListEmployees[index].Department = (string)cbDepartment.SelectedItem;
            myListEmployees[index].Comission = (double)trackComission.Value / 100;

            FileHandler.WriteToBinFile(myListEmployees);
            //We read the list and update the grid
            UpdateGridView(FileHandler.ReadFromBinFile());
            MessageBox.Show("User Edited!");
            CleanFields();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtId.Enabled = true;
            CleanFields();
            gvEmployee.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtId.Enabled = true;

            int index = gvEmployee.CurrentRow.Index;
            myListEmployees.RemoveAt(index);

            FileHandler.WriteToBinFile(myListEmployees);

            UpdateGridView(FileHandler.ReadFromBinFile());

            MessageBox.Show("User Deleted!");

            CleanFields();
            gvEmployee.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Type something to search!");
            }
            else {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;

                // temp list to save the employees that match with the search condition
                List<Employee> tempList = new List<Employee>();
                foreach (Employee emp in myListEmployees)
                {
                    if (emp.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Department.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Email.ToUpper().Contains(txtSearch.Text.ToUpper()) || emp.Id.ToUpper().Contains(txtSearch.Text.ToUpper())) {
                        tempList.Add(emp);
                    }
                }
                UpdateGridView(tempList);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            UpdateGridView(myListEmployees);
            CleanFields();
        }
       //i should not have clicked this in the dsign
       //i have to leave it or it breaks
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
