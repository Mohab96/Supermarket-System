using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            Application.OpenForms[0].Show();
            this.Close();
        }

        bool emptyFields()
        {
            if (fullName.Text == String.Empty) return false;
            if (password.Text == String.Empty) return false;
            if (email.Text == String.Empty) return false;
            if (address.Text == String.Empty) return false;
            if (phoneNumber.Text == String.Empty) return false;
            if (cnfrmPassword.Text == String.Empty) return false;
            return true;
        }

        void showUserMainMenu()
        {
            this.Hide();
            userMainMenu mainMenu = new userMainMenu();
            mainMenu.Show();
            this.Close();
        }

        bool IsValidEmail(string email)
        {
            string trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")) return false;
            if (!email.Contains('.')) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(string number)
        {
            foreach (var item in number)
            {
                if (item < '0' || item > '9') return false;
            }
            return number.Length == 11;
        }

        int currID()
        {
            List<string> generalIdFile = Global.readFromFile(Global.fixedPathForGeneralID);
            int generalID = generalIdFile.Count == 0 ? 22 : int.Parse(generalIdFile[0]);
            generalID += 213;
            Global.clearFile(Global.fixedPathForGeneralID);
            Global.writeOnFile(Global.fixedPathForGeneralID, generalID.ToString());
            return generalID;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!emptyFields())
            {
                // If there is any empty field
                MessageBox.Show("Please fill all the fields", "Warning");
            }
            else if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Please enter a valid email", "Warning");
            }
            else if (!IsPhoneNumber(phoneNumber.Text))
            {
                MessageBox.Show("Please enter a valid phone number", "Warning");
            }
            else if (Global.adminsCredentials.Contains(email.Text) || Global.usersCredentials.Contains(email.Text))
            {
                // If the email already exists
                MessageBox.Show("This email already exists !!", "Warning");
            }
            else if (password.Text != cnfrmPassword.Text)
            {
                // If the two passwords don't match
                MessageBox.Show("The passwords don't match !!", "Warning");
            }
            else if (password.Text.Length <= 8)
            {
                MessageBox.Show("Please enter a valid password (not less than 8 charachters)", "Warning");
            }
            else
            {
                // Create a new customer in the system
                int generalID = currID();

                Global.clearFile(Global.fixedPathForGeneralID);
                Global.writeOnFile(Global.fixedPathForGeneralID, generalID.ToString());

                customer newCustomer = new customer(fullName.Text, password.Text, email.Text, phoneNumber.Text
                    , address.Text, generalID.ToString(), 500);
                Global.usersCredentials[email.Text] = password.Text;
                Global.customersIDs.Add(generalID.ToString());
                Global.allCustomers[generalID.ToString()] = newCustomer;

                Global.currCustomer = newCustomer;
                Global.writeOnFile(Global.fixedPathForAllCustomersIDs, newCustomer.Id);
                MessageBox.Show("You have complete the sign up successfully..", "Congrats !!");

                showUserMainMenu();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
                cnfrmPassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                cnfrmPassword.PasswordChar = '*';
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            fullName.Text = String.Empty;
            email.Text = String.Empty;
            address.Text = String.Empty;
            phoneNumber.Text = String.Empty;
            password.Text = String.Empty;
            cnfrmPassword.Text = String.Empty;
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
