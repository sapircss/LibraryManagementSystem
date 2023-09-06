using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace librarymanagementsystem
{
    public class LibraryItem : Library
    {
        private const string QuantityChangeParamName = "@QuantityChange";
        private const string TitleParamName = "@Title";
        protected string title;
        protected string location;
        protected string shelf;
        protected int qnty;
        protected int upc;

        //getters and setters 

        public string Title { get; set; }
        public string Location { get; set; }
        public string Shelf { get; set; }   
        public int Qnty { get; set; }
        public int Upc { get; set; }
          

        public enum Type
        {
            Book,
            CD,
            DVD
        };
        //functions

     
       protected static DataTable ExecuteSelectQuery(string query) //to fill databae accordinhg to spesific query
        {
            return ExecuteSelectedQuery(query);
        }


      protected static string checkItemType(Type libItemType)
        {
            string tableName = "";
            switch (libItemType)
            {
                case Type.Book:
                    tableName = "books_stock";
                    break;
                case Type.CD:
                    tableName = "CD_stock";
                    break;
                case Type.DVD:
                    tableName = "DVD_stock";
                    break;
                default:
                    break;
            }
            return tableName;

        }

        public static void UpdateStock(Type libItemType,
            string libItemTitle,
            bool isBorrow) //setquantity
        {
            string tableName = checkItemType(libItemType);
            try
            {
                
                  string query = $"UPDATE {tableName} SET quantity = " +
                $"quantity + {QuantityChangeParamName} WHERE title={TitleParamName}";
                    ExecuteNonQuery(query,
                        new[] { QuantityChangeParamName, TitleParamName },
                        new object[] { isBorrow ? -1 : 1, libItemTitle });
               
            }

            catch
            {
                MessageBox.Show("Error in updatestock function");
            }
  
        }

        protected static void ExecuteNonQuery(string query, string[] paramsNames, object[] paramsVal)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            if (paramsNames != null)
            {
                for (int i = 0; i < paramsNames.Length; i++)
                    cmd.Parameters.AddWithValue(paramsNames[i], paramsVal[i]);
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }

      protected void InsertOrUpdateNewItem(string query) //insert new item - for employee update stock 
        {  
                insertOrUpdateToDataBase(query);
        }

   
      protected void UpdateTableStock(Type libItemType, string value, string valToUpdate, int upc)
        {
            string tableName = checkItemType(libItemType);
            string query = $"UPDATE {tableName} SET {value} = '" + valToUpdate + "' where upc = '"+upc+"' ";
            insertOrUpdateToDataBase(query);
        }

       protected void DeleteItemFromStock(Type libItemType, int upc)
        {
            string tableName = checkItemType(libItemType);
            string query = $"delete from {tableName} where upc = '" + upc + "'";
            insertOrUpdateToDataBase(query);   
        }

    }
    }

