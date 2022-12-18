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
    public partial class QuantityForm : Form
    {
        public QuantityForm()
        {
            InitializeComponent();
            MessageBox.Show(Global.currProduct.Price.ToString());
        }
        double price = Global.currProduct.Price;
        double discount = Global.currProduct.Discount;
        int qty = 1;
        private void QuantityForm_Load(object sender, EventArgs e)
        {
            txtqty.Maximum = Global.currProduct.Quantity;
            lblprice.Text = "$ " + price.ToString();
            lbloff.Text = discount.ToString() + "% OFF";
            lblfinalprice.Text = "$ " + (price * (100-discount)/100.0).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if(Global.currCustomer.cart.ContainsKey(Global.currProduct))
            {
                Global.currCustomer.cart[Global.currProduct] += int.Parse(txtqty.Text);
            }
            else
            {
                Global.currCustomer.cart.Add(Global.currProduct, int.Parse(txtqty.Text));
            }
            this.Close();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtqty_ValueChanged(object sender, EventArgs e)
        {
            qty = int.Parse(txtqty.Value.ToString());
            lblprice.Text = "$ " + (price * qty).ToString();
            lblfinalprice.Text = "$ " + ((price * qty) * (100-discount) / 100.0).ToString();
        }

        private void lblfinalprice_Click(object sender, EventArgs e)
        {

        }
    }
}
