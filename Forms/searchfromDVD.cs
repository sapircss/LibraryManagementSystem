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
    public partial class searchfromDVD : Form
    {
        private User loggedInUser = new User();
       private DVD dvd = new DVD();
        public searchfromDVD(User user)
        {
            InitializeComponent();
            loggedInUser.Name = user.Name;
            loggedInUser.Password = user.Password;
        }

      

        private void searchfromDVD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet4.DVD_stock' table. You can move, or remove it, as needed.
            
            dvd.DisplayDVDStock();
        }

      

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            DVDgrdview.DataSource = dvd.searchDVDStock(searchtxt.Text);
        }

        private void refreshbtb_Click_1(object sender, EventArgs e)
        {

            dvd.DisplayDVDStock();
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
