using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class manageorders : Form
         
    {
        private Employee loggedInEmp = new Employee();
        public manageorders(Employee employee)
        {
            InitializeComponent();
            loggedInEmp.Name = employee.Name;
            loggedInEmp.Password = employee.Password;
        }

        private void manageorders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.Data_Customers' table. You can move, or remove it, as needed.
            //this.data_CustomersTableAdapter.Fill(this.libraryManagementDataSet.Data_Customers);

        }

      

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            useridtxt.Text = "";
        }

       

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            employeeConsole empcons = new employeeConsole(loggedInEmp);
            empcons.Show();
            this.Close();
        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            User user = new User();
           
            if (user.verifyUserByID(useridtxt.Text))
            {
                MessageBox.Show("verified");
            }
            else
            {
                MessageBox.Show("user was not found");

            }


        }

      

        private void searchitembtn_Click_1(object sender, EventArgs e)
        {
            if (itemscmbox.Text == "book")
            {
                Book book = new Book();
                itemsgridview.DataSource = book.SearchBookStock(itemtextbox.Text);
            }

            else if (itemscmbox.Text == "CD")
            {
                CD cd = new CD();
                itemsgridview.DataSource = cd.searchCDStock(itemtextbox.Text);
            }

            else if (itemscmbox.Text == "DVD")
            {
                DVD dvd = new DVD();
                itemsgridview.DataSource = dvd.searchDVDStock(itemtextbox.Text);
            }


        }

        private void refreshitembtn_Click(object sender, EventArgs e)
        {
            itemtextbox.Text = "";
            if (itemscmbox.Text == "book")
            {
                Book book = new Book();
                itemsgridview.DataSource = book.DisplayBooksStock() ;
            }

            else if (itemscmbox.Text == "CD")
            {
                CD cd = new CD();
                itemsgridview.DataSource = cd.DisplayCDStock();
            }

            else if (itemscmbox.Text == "DVD")
            {
                DVD dvd = new DVD();
                itemsgridview.DataSource = dvd.DisplayDVDStock();
            }

        }

        private void itemsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            
            int selectedRowsIndex = itemsgridview.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = itemsgridview.Rows[selectedRowsIndex];
            string selLibItemActionName = itemsgridview.CurrentCell.Value.ToString();
            string selLibItemTitle = selectedRow.Cells["title"].Value.ToString();

            string quantity = selectedRow.Cells["quantity"].Value.ToString();

            LibraryItem.Type libItemType = LibraryItem.Type.Book;

            if (itemscmbox.Text == "book") { libItemType = LibraryItem.Type.Book; }
            else if (itemscmbox.Text == "CD") { libItemType = LibraryItem.Type.CD; }
            else if (itemscmbox.Text == "DVD") { libItemType = LibraryItem.Type.DVD; }

            try
            {
                 //if book is returned decrease quantity else increase quantity
                if (selLibItemActionName == "borrow")
                {
                    if (quantity.Equals('0') == false)
                    {
                        user.UserBorrow(selLibItemTitle, useridtxt.Text);
                        LibraryItem.UpdateStock(libItemType, selLibItemTitle, true);
                        MessageBox.Show("item borrowed successfully");
                    }
                    else { MessageBox.Show("item is out of stock!"); }
                }

                 if (selLibItemActionName == "return")
                {
                    user.UserReturn(selLibItemTitle, useridtxt.Text);
                    LibraryItem.UpdateStock(libItemType, selLibItemTitle, false);
                    MessageBox.Show("item returned successfully");
                }

              
            }

            catch { MessageBox.Show("Error from form!"); }
        }

        private void manageorders_Load_1(object sender, EventArgs e)
        {

        }
    }
}

