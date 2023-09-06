using LibraryManagementSystem;
using System;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class employeeConsole : Form
    {
        public static employeeConsole employeesConsoleInstance;
        private Employee loggedInEmp = new Employee();


        public employeeConsole(Employee employee)
        {
            InitializeComponent();
            employeesConsoleInstance = this;
            loggedInEmp.Name = employee.Name;
            loggedInEmp.Password = employee.Password;

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

      

        private void employeeConsole_Load(object sender, EventArgs e)
        {

        }

        

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            employees empform = new employees();
            empform.Show();
            this.Hide();

        }

        private void orderbtn_Click_1(object sender, EventArgs e)
        {
            manageorders mngordform = new manageorders(loggedInEmp);
            mngordform.Show();
            this.Hide();
        }

        private void manageusersbtn_Click(object sender, EventArgs e)
        {
            manageusers manangeusersform = new manageusers(loggedInEmp);
            manangeusersform.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            homepage homform = new homepage(); 
            homform.Show();
            this.Close();
        }

        private void mngstockbtn_Click(object sender, EventArgs e)
        {
            managestock stockform = new managestock(loggedInEmp);
            stockform.Show();
            this.Close();
        }
    }
}

