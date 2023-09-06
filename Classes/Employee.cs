using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;


namespace librarymanagementsystem
{
    public class Employee : Library
    {
        private string username;
        private string password;
        private int employeenum; 

        //getters and setters 

        public string Name { get { return username; } set { this.username = value; } }
        public string Password { get { return password; } set { this.password = value; } }
        public int EmployeeNumber { get { return employeenum; }  set { this.employeenum = value; } }
   


        //functions
        public bool verifyEmployee(string name, string password)
        {
            string querry = "SELECT * FROM Data_employees WHERE username = '" + name + "' AND password = '" + password + "'";
            return verifyUser(querry);
        }

        public static DataTable displaySelectedUser(string userID)
        {
            string query = "SELECT username,password, userID, address, phone, borrows FROM Data_Customers WHERE userID LIKE '%" + userID + "%'";
            return  ExecuteSelectedQuery(query);

        }

        public static DataTable displayAllUsers()
        {
            return ExecuteSelectedQuery("SELECT * FROM Data_Customers");

        }

        public DataTable updateSelectedUser(string name, string password, string id, string address, string phone, string borrows, string changeByuserID)
        {
            string query = "UPDATE Data_Customers SET username = '" + name + "', password = '" + password + "', userID = '" + id + "', address ='" + address + "', phone='" + phone + "', borrows='" + borrows + "' WHERE userID ='" + changeByuserID + "' ";
            return ExecuteSelectedQuery(query);

        }

        public DataTable deleteSelectedUser(string userId)
        {

            string query = "DELETE from Data_Customers where userID = '" + userId + "' ";
            return ExecuteSelectedQuery(query);

        }
        public DataTable createNewUser(string name, string password, string id, string address, string phone, string borrows)
        {
            string query = "insert into Data_Customers (username, password, userID, address, phone, borrows) values ('" + name + "', '" + password + "', '" + id + "', '" + address + "', '" + phone + "', '" + borrows + "')";
            return ExecuteSelectedQuery(query);
        }
    }
}
      

