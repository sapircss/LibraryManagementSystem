using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;
namespace librarymanagementsystem
{
    public class DVD : LibraryItem
    {
        private string actors;
        private string genre;
    
        //getters and setters 


        public string Actors { get;set; }
        public string Genre { get;set; }

       

        //functions
       
        public DataTable DisplayDVDStock()
        {
            string query = "SELECT * FROM DVD_stock";
            return ExecuteSelectQuery(query);

        }
        public DataTable searchDVDStock(string value) 
        {
            string query = "SELECT * FROM DVD_stock WHERE (title LIKE '%" + value + "%') OR (actors LIKE '%" + value + "%') OR (genre LIKE '%" + value + "%')";
            return ExecuteSelectQuery(query);
        }

        public void UpdateDVDStock(string DVDTitle, bool isBorrow)
        {
            UpdateStock(Type.DVD, DVDTitle, isBorrow);
        }

        public void insertNewDVD(string[] arr)
        {
            string query = "insert into DVD_stock (title, actors, genre, location, shelf, quantity) VALUES ('" + arr[0] + "', '" + arr[1] + "','" + arr[2] + "', '" + arr[3] + "', '" + arr[4] + "', '" + arr[5] + "')";
            InsertOrUpdateNewItem(query);
        }

        public void UpdateItemDVD(string[] arr, int upc)
        {

            string query = "update DVD_stock SET title='" + arr[0] + "' , actors= '" + arr[1] + "', genre = '" + arr[2] + "', location = '" + arr[3] + "', shelf = '" + arr[4] + "', quantity = '" + arr[5] + "' where upc = '" + upc + "' ";
            InsertOrUpdateNewItem(query);
        }

        public void DeleteDVDFromStock(int upc)
        {
            DeleteItemFromStock(Type.DVD, upc);

        }

        public DataTable searchDVDByTitle(string value)
        {
            string query = "select * from DVD_stock where title LIKE '%" + value + "%' ";
            return ExecuteSelectQuery(query);


        }
        public DataTable searchDVDByUPC(int upc)
        {
            string query = "select * from DVD_stock where upc LIKE '%" + upc + "%' ";
            return ExecuteSelectQuery(query);


        }
    }
}
