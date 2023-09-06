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
    public partial class searchfromCD : Form
    {
        private User loggedInUser = new User();
       private CD cd = new CD();
        public searchfromCD(User user)
        {
            InitializeComponent();
            loggedInUser.Name = user.Name;
            loggedInUser.Password= user.Password;
        }

        private void searchfromCD_Load(object sender, EventArgs e)
        {
           CDgrdview.DataSource =  cd.DisplayCDStock();
        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            CDgrdview.DataSource = cd.searchCDStock(searchtxt.Text);
        }

        private void refreshbtb_Click_1(object sender, EventArgs e)
        {
            CDgrdview.DataSource = cd.DisplayCDStock();
            searchtxt.Text = "";

        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            searchitems searchitemform = new searchitems(loggedInUser);
            searchitemform.Show();
            this.Close();
        }
    }
}
