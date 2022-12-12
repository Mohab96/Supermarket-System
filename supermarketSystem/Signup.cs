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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hiding the current form 
            Form1 login = new Form1(); //taking object of the login form 
            login.ShowDialog();  //showing the contents of the signup form
            this.Close(); // closing the current from to avoid memory issues 
        }

        bool emptyFields()
        {
            if (fullName.Text == String.Empty) return false;
            if (password.Text == String.Empty) return false;
            if (email.Text == String.Empty) return false;
            if (address.Text == String.Empty) return false;
            if (phoneNumber.Text == String.Empty) return false;
            return true;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!emptyFields())
            {
                // If there is any empty field
                MessageBox.Show("Please fill all the fields", "Warning");
            }
            else if (Global.adminsCredentials.Contains(email.Text) || Global.usersCredentials.Contains(email.Text))
            {
                // If the email already exists
                MessageBox.Show("This email already exists !!", "Warning");
            }
            else
            {
                // Create a new customer in the system
                List<string> generalIdFile = Global.readFromFile(Global.fixedPathForGeneralID);
                int generalID = int.Parse(generalIdFile[0]);
                generalID += 213;

                Global.clearFile(Global.fixedPathForGeneralID);
                Global.writeOnFile(Global.fixedPathForGeneralID, generalID.ToString());

                customer newCustomer = new customer(fullName.Text, password.Text, email.Text, phoneNumber.Text
                    , address.Text, generalID.ToString(), 500);
                Global.usersCredentials[email.Text] = password.Text;
                Global.customersIDs.Add(generalID.ToString());
                Global.allCustomers[generalID.ToString()] = newCustomer;

                MessageBox.Show("You have complete the sing sign up successfully\nGo login now ..", "Congrats !!");

            }
        }
    }
}
