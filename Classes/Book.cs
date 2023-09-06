using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace librarymanagementsystem
{
    public class Book : LibraryItem
    {
        private string isbn;
        private string author;
        private string category;
        private string publication;
       

        //getters and setters 

      
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }   
        public string Publication { get; set; }

     
          
              

        //functions
        
        public DataTable DisplayBooksStock()
        {
            string query = "SELECT * FROM books_stock";
            return ExecuteSelectQuery(query);


        }
        public DataTable SearchBookStock(string value)//search for users
        {
          string query = $"SELECT * FROM books_stock WHERE (title LIKE '%" + value+ "%') OR (category LIKE '%"+value+"%') OR (author LIKE '%" +value +"%') OR (isbn LIKE '%" +value+ "%') OR (publication LIKE '%" +value+"%')";
           return ExecuteSelectQuery(query);

        }

        public void UpdateBooksStock(string bookTitle, bool isBorrow) //update user borrow and set new quantity
        {
            UpdateStock(Type.Book, bookTitle, isBorrow);
        }

        public void DeleteBookFromStock(int upc)
        {
            DeleteItemFromStock(Type.Book, upc);

        }

        public void insertNewBook(string[]arr)
        {
            string query = "insert into books_stock (title, isbn, author, category, publication, location, shelf, quantity) VALUES ('"+ arr[0]+ "', '"+ arr[1]+ "','"+ arr[2]+ "', '"+ arr[3]+ "', '"+ arr[4]+ "', '"+ arr[5]+ "', '"+ arr[6]+ "', '"+ arr[7]+"') ";
            InsertOrUpdateNewItem(query);
        }

        public void UpdateItemBook(string[] arr, int upc)
        {
           
            string query = "update books_stock SET title='" + arr[0] + "' , isbn= '" + arr[1] + "', author = '" + arr[2] + "', category = '" + arr[3] + "', publication = '" + arr[4] + "', location = '" + arr[5] + "', shelf = '" + arr[6] + "', quantity = '" + arr[7] + "' where upc = '" + upc + "' ";
            InsertOrUpdateNewItem(query);
        }

    }
}
