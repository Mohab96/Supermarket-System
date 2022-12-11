using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hiding the current form 
            Signup signup = new Signup(); //taking object of the signup form 
            signup.ShowDialog();  //showing the contents of the signup form
            this.Close();  // closing the current form to avoid memory issues 
        }

      public string currUserId(string Email)
        {
            // method to get the id of the customer that currently signed in
            foreach (var item in Global.customersIDs)
            {
                List<string> temp;
                string path = "CustomerID_" + item + ".txt";
                temp = Global.readFromFile(path);
                if (temp[2] == EmailTextbox.Text)
                {
                    return item;
                }
            }
            return null;
        }
        public string currAdminId(string Email)
        {
            // method to get the id of the admin that currently signed in
            foreach (var item in Global.adminsIDs)
            {
                List<string> temp;
                string path = "AdminID_" +item + ".txt";
                temp = Global.readFromFile(path);
                if (temp[2] == EmailTextbox.Text)
                {
                    return item;
                }
            }
            return null;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == string.Empty || EmailTextbox.Text == string.Empty)
            {   // checking that all textboxes are not empty
                MessageBox.Show("Please Fill All The Information");
                return;
            }
            if (Global.usersCredentials.ContainsKey(EmailTextbox.Text) && (string)Global.usersCredentials[EmailTextbox.Text]==PasswordTextbox.Text)
            {   // checking that the Email and password are right
                string curr_ID = currUserId(EmailTextbox.Text);  // holds the current signed in customer id
                if (curr_ID != null) 
                {
                    Global.currCustomer =(customer)Global.allCustomers[curr_ID];
                }
                // show the user main menu 

                return;
            }
            if (Global.adminsCredentials.ContainsKey(EmailTextbox.Text) && (string)Global.adminsCredentials[EmailTextbox.Text]==PasswordTextbox.Text)
            {   // checking that the Email and password are right

                string curr_ID = currAdminId(EmailTextbox.Text); // holds the current signed in admin id
                if (curr_ID != null) 
                { 
                    Global.currAdmin=(admin)Global.allAdmins[curr_ID];
                }
                // show the admin main menu 


                return;
            }
            MessageBox.Show("Sorry..invalid Email or password");

        }
    }
}
