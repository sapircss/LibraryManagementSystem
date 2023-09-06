
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class homepage : Form
    {
        public static homepage homepageInstance;

        public homepage()
        {
            InitializeComponent();
            homepageInstance = this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book = new Book();


         ;
            
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

   

        
      

        private void Customerloginbtn_Click_1(object sender, EventArgs e)
        {
            Customers cusform = new Customers();
            cusform.Show();
            this.Hide();
        }

        private void employeeloginbtn_Click_1(object sender, EventArgs e)
        {
            employees empform = new employees();
            empform.Show();
            this.Hide();
        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {

                this.Show();
            }

        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
