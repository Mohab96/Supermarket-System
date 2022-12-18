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
    public partial class invoice_form : Form
    {
        public invoice_form()
        {
            InitializeComponent();
        }
        public double totalcashneeded;
        
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mohab96/Supermarket-System");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            textBox2.Text = DateTime.Now.ToString("dd/mm/yyy");
            label7.Text = Global.currCustomer.FullName;
   
            label12.Text = Global.currCustomer.cart.Count.ToString();
            foreach(var pro in Global.currCustomer.cart)
            {
                string name = pro.Key.Name;
                int quantity = pro.Value;
                double totalprice = quantity * pro.Key.Price;
                totalcashneeded += totalprice;
                
            }
            label13.Text = totalcashneeded.ToString();



        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;


            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
