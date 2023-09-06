using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace librarymanagementsystem
{


    public partial class manageusers : Form
    {

        public static manageusers manageusersInstance;
        private Employee loggedInEmp = new Employee();
        private bool isRowEmpty = true;
        public manageusers(Employee employee)
        {
            InitializeComponent();
         
            manageusersInstance = this;
            loggedInEmp.Name = employee.Name;
            loggedInEmp.Password = employee.Password;
            

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            employeeConsole empconsform = new employeeConsole(loggedInEmp);
            empconsform.Show();
            this.Close();
        }

        private void newuserbtn_Click(object sender, EventArgs e)
        {

        }

        private void newuserbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void manageusers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet2.Data_Customers' table. You can move, or remove it, as needed.
            //this.data_CustomersTableAdapter.Fill(this.libraryManagementDataSet2.Data_Customers);
            usersgridviews.DataSource = Employee.displayAllUsers();


        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void usersgridviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowsIndex = usersgridviews.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = usersgridviews.Rows[selectedRowsIndex];

           

            if (string.IsNullOrEmpty(useridtxt.Text))
            {
              useridtxt.Text = selectedRow.Cells["userID"].Value.ToString();

            }
            for(int i=0; i<selectedRow.Cells.Count;i++ )
            {
                if (selectedRow.Cells[i].ToString() != string.Empty)
                {
                    isRowEmpty = false;
                }

            }
           

        }

        private void search_Click(object sender, EventArgs e)
        {
            usersgridviews.DataSource = Employee.displaySelectedUser(useridtxt.Text);
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            employeeConsole empcons = new employeeConsole(loggedInEmp);
            empcons.Show();
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            

            int selectedRowsIndex = usersgridviews.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = usersgridviews.Rows[selectedRowsIndex];
            string username = selectedRow.Cells["username"].Value.ToString();
            string password = selectedRow.Cells["password"].Value.ToString();
            string userID = selectedRow.Cells["userID"].Value.ToString();
            string address = selectedRow.Cells["address"].Value.ToString();
            string phone = selectedRow.Cells["phone"].Value.ToString();
            string borrows = selectedRow.Cells["borrows"].Value.ToString();

           

            MessageBox.Show(address);
            if(isRowEmpty == false)
            {
                usersgridviews.DataSource = loggedInEmp.updateSelectedUser(username, password, userID, address, phone, borrows, useridtxt.Text);
            }
            else if (isRowEmpty == true)
            {
                usersgridviews.DataSource = loggedInEmp.createNewUser(username, password, userID, address, phone, borrows);

            }
           
      

        }

        private void refrshbtn_Click(object sender, EventArgs e)
        {
           
            useridtxt.Text = "";
            usersgridviews.DataSource = Employee.displayAllUsers();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int selectedRowsIndex = usersgridviews.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = usersgridviews.Rows[selectedRowsIndex];
            string userID = selectedRow.Cells["userID"].Value.ToString();

            DialogResult res;
            res = MessageBox.Show("Do you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                usersgridviews.DataSource = loggedInEmp.deleteSelectedUser(userID);
            }

            else
            {
               
                useridtxt.Text = "";
                usersgridviews.DataSource = Employee.displayAllUsers();

            }


        }
    }
}
