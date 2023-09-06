using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace librarymanagementsystem
{

    public partial class employees : Form
    {
        public static employees employeesInstance;
        private Employee loggedInEmp; 

        public employees()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
            employeesInstance = this;

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

       



        private void employees_Load(object sender, EventArgs e)
        {

        }

       

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            loggedInEmp = new Employee();
                if(loggedInEmp.verifyEmployee(usernametxt.Text, passwordtxt.Text)== true)
                {
                    {
                        loggedInEmp.Name = usernametxt.Text;
                        loggedInEmp.Password = passwordtxt.Text;

                    }
                    MessageBox.Show("welcome " + loggedInEmp.Name);
                    employeeConsole empcons = new employeeConsole(loggedInEmp);
                    empcons.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usernametxt.Clear();
                    passwordtxt.Clear();

                    //to focus username

                    usernametxt.Focus();

                }

        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {

                this.Show();
            }
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            homepage homeform = new homepage();
            homeform.Show();
            this.Close();
        }

        private void employees_Load_1(object sender, EventArgs e)
        {

        }
    }
}
