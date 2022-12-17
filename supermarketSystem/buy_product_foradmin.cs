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
            double txt_pec = double.Parse(textBox1.Text);
            double res = txt_pec * Global.currProduct.Price;

            total_price.Text = res.ToString();
        }

        bool ValidData(int pec , string s)
        {
            if(pec <= 0)
            {
                return false ; 
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 49 || s[i] > 57)
                {
                    return false;
                }
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = txt_pec.ToString();
            txt_pec = Convert.ToUInt32(textBox1);
            /// (mohab) => (mas) : What if the quantity is less than or equal to zero .. verify this >> done 
            /// (mohab) => (mas) : What if the quantity entered is text .. verify this >> done 

            if (!ValidData(int.Parse(txt_pec.ToString()) , s))
            {
                MessageBox.Show("Please enter a valid data (numbers > 0)");
                return ;
            }

            Global.currProduct.Quantity += Convert.ToInt32(txt_pec);
            Global.currCustomer.CashBalance -= res ;
            /// (mohab) => (mas) : You forgot to update the Global.cashBalance >> done


            MessageBox.Show("Done your cash now = {0}", Global.currCustomer.CashBalance.ToString());

            this.Hide();
            adminMainMenu back = new adminMainMenu();
            back.ShowDialog();
            this.Close();
            /// (mohab) => (mas) : You forgot to close the form after you have finished >> done

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMainMenu back = new adminMainMenu();
            back.ShowDialog();
            this.Close();
        }
    }
}
