using System;
using System.IO;
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
    public partial class buy_product_foradmin : Form
    {
        
        double txt_pec;
        double res;



        public buy_product_foradmin()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buy_product_foradmin_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Global.currProduct.image;
            quan_lbl.Text = Global.currProduct.Quantity.ToString() ;
            price_lbl.Text = Global.currProduct.Price.ToString() ;
            cash_lbl.Text = Global.currCustomer.CashBalance.ToString() ;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double txt_pec = Convert.ToDouble(textBox1);
            double res = txt_pec * Global.currProduct.Price;

            total_price.Text = res.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /// (mohab) => (mas) : What if the quantity is less than or equal to zero .. verify this 
            /// (mohab) => (mas) : What if the quantity entered is text .. verify this 
            txt_pec = Convert.ToUInt32(textBox1);
            
            Global.currProduct.Quantity += Convert.ToInt32(txt_pec);
            /// (mohab) => (mas) : You forgot to update the Global.cashBalance


            Global.currCustomer.CashBalance -= res ;

            MessageBox.Show("Done your cash now = {0}", Global.currCustomer.CashBalance.ToString());

            
            /// (mohab) => (mas) : You forgot to close the form after you have finished

        }
    }
}
