using LibraryManagementSystem;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.CodeDom;
using System;
using System.Reflection;

namespace LibraryManagementSystem
{
    public abstract class Library
    {
       protected static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-41QOMHR;Initial Catalog=libraryManagement;Integrated Security=True");


        protected static DataTable ExecuteSelectedQuery(string query) //to fill databae accordinhg to spesific query
        {
           
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                conn.Close();
                return data;  
           
        }




        protected void insertOrUpdateToDataBase(string query)//insert new item in database tables
        {

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            catch { MessageBox.Show("error from InsertOrUpdate function"); }


        }

        protected bool verifyUser(string query)
        {

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return true;
            }

            else

                return false;
        }
    }
}
