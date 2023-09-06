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
    public partial class newuserform : Form
    {
        public static newuserform newuserInstance;
        public newuserform()
        {
            InitializeComponent();
            newuserInstance = this;
        }

        

        
       

        private void savechangesbtn_Click_1(object sender, EventArgs e)
        {


            User user = new User();
            user.createNewUser(usernametxt.Text, passwordtxt.Text, useridtxt.Text, phonenumbertxt.Text, addresstxt.Text);
            this.Close();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            homepage homeform = new homepage();
            homeform.ShowDialog();
        }
    }
}
