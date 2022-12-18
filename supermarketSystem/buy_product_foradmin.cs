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
            txt_pec = int.Parse(textBox1.Text);
            double tot_price = txt_pec * Global.currProduct.Price;

            total_price.Text = tot_price.ToString();
        }

        bool ValidPrice(string price)
        {
            if(price[0]==0)
            {
                return false;
            }

            for (int i = 0; i < price.Length; i++)
            {
                if (!(price[i]>=48 && price[i]<=57))
                {
                    return false;
                }
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string prc = txt_pec.ToString();
            if (!ValidPrice(prc))
            {
                MessageBox.Show("Please enter a valid data (numbers > 0)");
                return ;
            }
            tot_price = txt_pec * Global.currProduct.Price;

            if (tot_price > Global.cashBalance)
            {
                MessageBox.Show("You don't have enough cash");
                return;
            }

            Global.currProduct.Quantity += Convert.ToInt32(txt_pec);
            Global.cashBalance -= tot_price;

            MessageBox.Show("Done.. your cash now" + Global.cashBalance.ToString());

            this.Hide();
            adminMainMenu back = new adminMainMenu();
            back.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMainMenu back = new adminMainMenu();
            back.ShowDialog();
            this.Close();
        }

        private void buy_product_foradmin_Load_1(object sender, EventArgs e)
        {
            lbl_name.Text = Global.currProduct.Name;
            pictureBox1.Image = Global.currProduct.image;
            quan_lbl.Text = Global.currProduct.Quantity.ToString();
            price_lbl.Text = Global.currProduct.Price.ToString();
            cash_lbl.Text = Global.cashBalance.ToString();
        }
    }
}
