using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;


namespace librarymanagementsystem
{
    public class User : Library 
       
    {

        private int clientID;
        private string username;
        private string password;
        private string userID;
        private string adress;
        private string phone;


        //getters and setters 
        public string Name { get { return this.username; }set{ this.username = value; }}
        public string Password {get{ return this.password; }set{ this.password = value; } }
        public string UserID { get{ return this.userID; }set{ this.userID = value; }}
        public int ClientID { get { return this.clientID; }set { this.clientID = value; }}
    


        //functions


        public bool verifyUser(string name, string password)
        {
            string querry = "SELECT * FROM Data_Customers WHERE username = '" + name + "' AND password = '" + password + "'";
           return verifyUser(querry);                                           
        }

        public bool verifyUserByID(string id) //overload
        {
            string query = "SELECT * FROM Data_Customers WHERE userID = '"+id+"' ";
            return verifyUser(query);
        }
        public DataTable displayCurrentUserDetails(User user)
        {
                string query = "SELECT username, userID, address, phone, borrows FROM Data_Customers WHERE username = '" + user.username + "' and password = '"+user.password+"'";
                return ExecuteSelectedQuery(query);
        }

        public void createNewUser(string name, string password, string id, string phoneNum, string address)
        { 
           string query = "insert into Data_Customers (username, password, userID, address, phone, borrows) values ('" + name + "', '" + password + "', '" + id + "', '" + phoneNum + "', '" + address + "', NULL)";
           try
            {
                insertOrUpdateToDataBase(query);
                MessageBox.Show("user created successfully!");
            }
            catch { MessageBox.Show("Error in creating user!"); }           
        }

        public void UserBorrow(string value, string userID)
        {
            string comma = ",";
            string query = "update Data_Customers SET borrows = concat('" + value + "', '" + comma + "' ,borrows)  WHERE userID ='" + userID + "' ";
            insertOrUpdateToDataBase(query);
        }

        public void UserReturn(string value, string userID)
        {
            string valToDelete = value + ",";
            string query = "update Data_Customers SET borrows = REPLACE(borrows,  '" + valToDelete + "', '') WHERE (userID ='" + userID + "') ";
            insertOrUpdateToDataBase(query);
        }

    }
}






















