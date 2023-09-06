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
    public partial class UsersConsole : Form
    {
        public static UsersConsole UsersConsoleInstance;
        private User loggedInUser = new User(); 
        
        
      
        public UsersConsole(User user)
        {
            
            InitializeComponent();
            UsersConsoleInstance = this;
            loggedInUser.Name = user.Name;
            loggedInUser.Password = user.Password;

        }

        private void UsersConsole_Load(object sender, EventArgs e)
        {
            
        }

      
        private void logoutbtn_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            searchitems srcform = new searchitems(loggedInUser);
            srcform.Show();
        }

        private void orderbtn_Click_1(object sender, EventArgs e)
        {
            userordersdetails ordform = new userordersdetails(loggedInUser);
            ordform.Show();
            this.Hide();

        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
