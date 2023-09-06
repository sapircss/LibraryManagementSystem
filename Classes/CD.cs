using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace librarymanagementsystem
{
    public class CD : LibraryItem
    {
        private string artist;
        private string genre;

        //getters and setters 

        public string Artist { get; set; }
        public string Genre { get; set; }

      

        //functions
      

        public DataTable DisplayCDStock()
        {
            string query = "SELECT * FROM CD_stock";
            return ExecuteSelectQuery(query);


        }
        public DataTable searchCDStock(string value)
        {
            string query = "SELECT * FROM CD_stock WHERE (title LIKE '%" + value + "%') OR (artist LIKE '%" + value + "%') OR (genre LIKE '%" + value + "%')"; 
            return ExecuteSelectQuery(query);
        }

        public void UpdateCDStock(string CDTitle, bool isBorrow)
        {
            UpdateStock(Type.CD, CDTitle, isBorrow);
        }

        public void UpdateItemCD(string[] arr, int upc)
        {

            string query = "update CD_stock SET title='" + arr[0] + "' , artist= '" + arr[1] + "', genre = '" + arr[2] + "', location = '" + arr[3] + "', shelf = '" + arr[4] + "', quantity = '" + arr[5] + "' where upc = '" + upc + "' ";
            InsertOrUpdateNewItem(query);
        }
        public void DeleteCDFromStock(int upc)
        {
            DeleteItemFromStock(Type.CD, upc);

        }
        public void insertNewCD(string[] arr)
        {
            string query = "insert into CD_stock (title, artist, genre, location, shelf, quantity) VALUES ('" + arr[0] + "', '" + arr[1] + "','" + arr[2] + "', '" + arr[3] + "', '" + arr[4] + "', '" + arr[5] + "')";
            InsertOrUpdateNewItem(query);
        }

        public DataTable searchCDByTitle(string value)
        {
            string query = "select * from CD_stock where title LIKE '%" + value + "%' ";
            return ExecuteSelectQuery(query);


        }
        public DataTable searchCDByUPC(int upc)
        {
            string query = "select * from CD_stock where upc LIKE '%" + upc + "%' ";
            return ExecuteSelectQuery(query);

        }
    }
}
