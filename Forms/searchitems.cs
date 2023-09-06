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
    public partial class searchitems : Form
    {
        public static searchitems searchitemsInstance;
        private User loggedInUser = new User();

        public searchitems(User user )
        {
            InitializeComponent();
            itemcombobox.Items.Add("book");
            itemcombobox.Items.Add("CD");
            itemcombobox.Items.Add("DVD");
            searchitemsInstance = this;
            loggedInUser.Name= user.Name;
            loggedInUser.Password= user.Password;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        

        

        private void searchitems_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            string gettxt = itemcombobox.SelectedItem.ToString();

            switch (gettxt)
            {
                case "book":
                    this.Hide();
                    searchfrombooks srcbookform = new searchfrombooks(loggedInUser);
                    srcbookform.Show();
                    break;

                case "CD":
                    this.Hide();
                    searchfromCD srccdform = new searchfromCD(loggedInUser);
                    srccdform.Show();
                    break;

                case "DVD":
                    this.Hide();
                    searchfromDVD srcdvdform = new searchfromDVD(loggedInUser);
                    srcdvdform.Show();
                    break;

            }
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            UsersConsole userconform = new UsersConsole(loggedInUser);
            userconform.Show();
            this.Close();
        }
    }
}
