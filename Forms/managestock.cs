using librarymanagementsystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class managestock : Form
    {
        private Employee loggedInEmp = new Employee();
        private bool isRowEmpty = true;
        private Book book = new Book();
        private CD cd = new CD();
        private DVD dvd = new DVD();

        public managestock(Employee employee)
        {
            InitializeComponent();
            loggedInEmp.Name = employee.Name;
            loggedInEmp.Password= employee.Password;
            
        }

        private void stockgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowsIndex = stockgridview.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow =stockgridview.Rows[selectedRowsIndex];
            selectedRow.Cells["upc"].ReadOnly = true;



            if (string.IsNullOrEmpty(itemtextbox.Text))
            {
                itemtextbox.Text = selectedRow.Cells["upc"].Value.ToString();
               
            }
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                if (selectedRow.Cells[i].ToString() != string.Empty)
                {
                    isRowEmpty = false;
                }

            }


        }

        private void itemscmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemscmbox.Text == "book")
            {
               
                stockgridview.DataSource = book.DisplayBooksStock();
            }

            else if (itemscmbox.Text == "CD")
            {
               
                stockgridview.DataSource = cd.DisplayCDStock();
            }

            else if (itemscmbox.Text == "DVD")
            {
               
                stockgridview.DataSource = dvd.DisplayDVDStock();
            }
        }

        private void itemtextbox_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
      
           
            int selectedRowsIndex = stockgridview.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = stockgridview.Rows[selectedRowsIndex];
            int upc;
            int arrsize = selectedRow.Cells.Count - 1;
            string[] listToUpdate = new string[arrsize];
            int j = 0;
            MessageBox.Show(isRowEmpty.ToString());
            try
            {
                for (int i = 1; i < selectedRow.Cells.Count; i++)
                { listToUpdate[j] = selectedRow.Cells[i].Value.ToString(); j++; }
                if (isRowEmpty == false)
                {
                    upc = (int)(selectedRow.Cells["upc"].Value);
                    if (itemscmbox.Text == "book") { book.UpdateItemBook(listToUpdate, upc); }
                    if (itemscmbox.Text == "DVD") { dvd.UpdateItemDVD(listToUpdate, upc); }
                    if (itemscmbox.Text == "CD") { cd.UpdateItemCD(listToUpdate, upc); }
                }
                else if (isRowEmpty == true)
                {
                    if (itemscmbox.Text == "book") {      book.insertNewBook(listToUpdate);   }
                    if (itemscmbox.Text == "DVD") {  dvd.insertNewDVD(listToUpdate); }
                    if (itemscmbox.Text == "CD") {  cd.insertNewCD(listToUpdate); }
                }

                MessageBox.Show("updated successfully");


            }
            catch { MessageBox.Show("error!"); }
           

        }

        private void refrshbtn_Click(object sender, EventArgs e)
        {
            itemtextbox.Text = "";
            if (itemscmbox.Text == "book"){ stockgridview.DataSource = book.DisplayBooksStock();}
            if (itemscmbox.Text == "CD") { stockgridview.DataSource = cd.DisplayCDStock();}
            if(itemscmbox.Text == "DVD"){stockgridview.DataSource = dvd.DisplayDVDStock();}
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           
            int selectedRowsIndex = stockgridview.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = stockgridview.Rows[selectedRowsIndex];
            int itemUPC = (int)(selectedRow.Cells["upc"].Value);
            DialogResult res;
            

            res = MessageBox.Show("Do you want to delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (itemscmbox.Text == "book") { book.DeleteBookFromStock(itemUPC); }
                else if (itemscmbox.Text == "CD") { cd.DeleteCDFromStock(itemUPC); }
                else if (itemscmbox.Text == "DVD") { dvd.DeleteDVDFromStock(itemUPC); }

            }

            else{ itemtextbox.Text = "";}
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            employeeConsole empcons = new employeeConsole(loggedInEmp);
            empcons.Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
                if (itemscmbox.Text == "book") { stockgridview.DataSource = book.SearchBookStock(itemtextbox.Text); }
                if (itemscmbox.Text == "DVD"){ stockgridview.DataSource =  dvd.searchDVDStock(itemtextbox.Text); }
                if (itemscmbox.Text == "CD"){ stockgridview.DataSource =  cd.searchCDStock(itemtextbox.Text);}

        }
    }
}
