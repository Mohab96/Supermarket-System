using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketSystem
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        public Button button = new Button();
        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkmostafafouab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/MostafaFouad0");
        }

        private void linkmostafa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JOE362");
        }

        private void linkarwa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/arwasaad2003");
        }

        private void linkmohab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Mohab96");
        }

        private void linkyossif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JOE362");
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to Quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (Global.currCustomer ==null)
            {
                adminMainMenu admin = new adminMainMenu();
                admin.Show();
            }
            else if(Global.currCustomer!= null)
            {
                userMainMenu user = new userMainMenu();
                 user .Show(); 
            }
          
       
            this.Close();
        }
    }
}
