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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mohab96/Supermarket-System");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("dd/mm/yyy");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
