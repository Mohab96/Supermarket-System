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
    public partial class adminORuser : Form
    {
        public adminORuser()
        {
            InitializeComponent();
        }

        void showuser()
        {
            userMainMenu user = new userMainMenu();
            user.Show();
            this.Close();
        }

        void showlogin()
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showuser();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showlogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showuser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showlogin();
        }
    }
}
