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

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == string.Empty || EmailTextbox.Text == string.Empty)
            {   // checking that all textboxes are not empty
                MessageBox.Show("Please Fill All The Information");
                return;
            }
            if (Global.usersCredentials.ContainsKey(EmailTextbox.Text))
            {
                // show the user main menu 
                return;
            }
            if (Global.adminsCredentials.ContainsKey(EmailTextbox.Text))
            {
                // show the admin main menu 
                return;
            }
            MessageBox.Show("Sorry..invalid Email or password");

        }
    }
}
