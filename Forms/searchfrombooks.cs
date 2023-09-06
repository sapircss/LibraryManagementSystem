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
    public partial class searchfrombooks : Form
    {
        private Book book = new Book();
        private User loggedInUser = new User();

        public searchfrombooks(User user)
        {
            InitializeComponent();
            loggedInUser.Name= user.Name;
            loggedInUser.Password= user.Password;

        }
       


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchfrombooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet2.books_stock' table. You can move, or remove it, as needed
          
            
            bookdataGridView1.DataSource = book.DisplayBooksStock();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srccombobox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void bookdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxt_TextChanged_1(object sender, EventArgs e)
        {




        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           


        }

        private void searchfrombooks_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.books_stock' table. You can move, or remove it, as needed.
         //   this.books_stockTableAdapter.Fill(this.libraryManagementDataSet.books_stock);

        }

        private void searchbtnn_Click(object sender, EventArgs e)//need to be edited by using claases function
        {
          bookdataGridView1.DataSource =  book.SearchBookStock(searchtxt.Text);


        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            bookdataGridView1.DataSource = book.DisplayBooksStock();
            
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            searchitems searchitemform = new searchitems(loggedInUser);
            searchitemform.Show();
            this.Close();

        }

        private void bookdataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
