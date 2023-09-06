using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class userordersdetails : Form
    {
        private User loggedInUser = new User();
        public userordersdetails(User user)
        {
            InitializeComponent();
            loggedInUser.Name= user.Name;
            loggedInUser.Password = user.Password;
        }

        private void userordersdetails_Load(object sender, EventArgs e)
        {

        }

        private void userordersdetails_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userAccountSet.Data_Customers' table. You can move, or remove it, as needed.
          //  this.data_CustomersTableAdapter.Fill(this.userAccountSet.Data_Customers);

        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            UsersConsole usrcons = new UsersConsole(loggedInUser);
            usrcons.Show();
            this.Close();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            userordersgridview.DataSource = loggedInUser.displayCurrentUserDetails(loggedInUser); 
        }
    }
}
