using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace supermarketSystem
{
    public partial class userMainMenu : Form
    {
        public userMainMenu()
        {
            InitializeComponent();
        }
        public bool close = true;
        private void userMainMenu_Load(object sender, EventArgs e)
        {
            name.Text = Global.currCustomer.FullName;
            money.Text = Global.currCustomer.CashBalance.ToString() + " $";
            foreach (var item in Global.mainMenuProducts)
            {
                itemForUserMainMenu newItem = new itemForUserMainMenu();
                product curProduct = Global.allProducts[item]; // The current product
                newItem.prdctPic.Image = curProduct.image;
                newItem.prdctName.Text = curProduct.Name;
                newItem.prdctPrice.Text = curProduct.Price.ToString() + " $" ;
                newItem.Product = curProduct;
                newItem.dis = curProduct.Discount.ToString();
                //newItem.Click += new EventHandler(this.Item_click);
                newItem.TopLevel = false;
                newItem.Show();
                productsMenu.Controls.Add(newItem);
            }
        }

        //void Item_click(object sender, EventArgs e)
        //{
        //    itemForUserMainMenu obj = (itemForUserMainMenu)sender;
        //    Global.currProduct = obj.Product;
        //    QuantityForm Qf = new QuantityForm();
        //    Qf.ShowDialog();
        //}

        private void goToPayForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cart checkout = new Cart();
            checkout.menu = this;
            checkout.ShowDialog();
            //this.Close();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Global.currCustomer = null;
            Application.OpenForms[0].Show();
            close = false;
            this.Close();
        }

        private void userMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == true)
                Application.Exit();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            close = false;
            this.Close();

        }

        private void money_Click(object sender, EventArgs e)
        {

        }

        private void productsMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
