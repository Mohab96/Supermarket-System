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
        product p;
        double txt_pec;

        

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
            pictureBox1.Image = p.image;
            quan_lbl.Text = p.Quantity.ToString() ;
            price_lbl.Text = p.Price.ToString() ;
            cash_lbl.Text = Global.currCustomer.CashBalance.ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double txt_pec = Convert.ToDouble(textBox1);
            double res = txt_pec * p.Price;

            total_price.Text = res.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_pec = Convert.ToUInt32(textBox1);
            p.Quantity += Convert.ToInt32(txt_pec);

            MessageBox.Show("done /n you buy {0}");
        }
    }
}
