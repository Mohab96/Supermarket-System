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

        double txt_pec = 0;
        double tot_price;


        public buy_product_foradmin()
        {
            InitializeComponent();
        }


        private void buy_product_foradmin_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool ValidPrice(string price)
        {
            if (price[0] == 0)
            {
                return false;
            }

            for (int i = 0; i < price.Length; i++)
            {
                if (!(price[i] >= 48 && price[i] <= 57))
                {
                    return false;
                }
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string prc = txt_pec.ToString();

            tot_price = txt_pec * Global.currProduct.Price;

            if (tot_price > Global.CashBalance)
            {
                MessageBox.Show("You don't have enough cash");
                return;
            }

            Global.currProduct.Quantity += Convert.ToInt32(txt_pec);
            Global.CashBalance -= tot_price;

            if (!Global.mainMenuProducts.Contains(Global.currProduct.Id))
                Global.mainMenuProducts.Add(Global.currProduct.Id);

            MessageBox.Show("Done.. your cash now " + Global.CashBalance.ToString());

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buy_product_foradmin_Load_1(object sender, EventArgs e)
        {
            lbl_name.Text = Global.currProduct.Name;
            pictureBox1.Image = Global.currProduct.image;
            quan_lbl.Text = Global.currProduct.Quantity.ToString();
            price_lbl.Text = Global.currProduct.Price.ToString();
            cash_lbl.Text = Global.CashBalance.ToString();
        }

        private void textBox1_ValueChanged(object sender, EventArgs e)
        {
            txt_pec = int.Parse(textBox1.Value.ToString());
            double tot_price = txt_pec * Global.currProduct.Price;

            total_price.Text = tot_price.ToString();
        }

        private void price_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
