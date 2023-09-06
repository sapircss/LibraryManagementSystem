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
    public partial class Customers : Form
    {
        public static Customers CustomersInstance;
        private User loggedInUser;//global variabal to store the current logged in user
        public Customers()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
            CustomersInstance = this; 
        }
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            homepage homeform = new homepage();
            homeform.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           loggedInUser = new User();
 
                if (loggedInUser.verifyUser(usernametxt.Text, passwordtxt.Text))
                {
                    {
                        loggedInUser.Name = usernametxt.Text;
                        loggedInUser.Password = passwordtxt.Text;
                    }

                    //page that needed to load next
                    MessageBox.Show("welcome "+loggedInUser.Name);
                    UsersConsole userscons = new UsersConsole(loggedInUser);
                    userscons.Show();
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
 
        private void newuserbtn_Click(object sender, EventArgs e)
        {
            newuserform userform = new newuserform(); 
            userform.Show(); 
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
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

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
