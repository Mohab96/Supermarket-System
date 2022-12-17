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
    public partial class userMainMenu : Form
    {
        public userMainMenu()
        {
            InitializeComponent();
        }
        private void userMainMenu_Load(object sender, EventArgs e)
        {
            name.Text = Global.currCustomer.FullName;
            money.Text = Global.currCustomer.CashBalance.ToString() + "LE.";
            foreach (var item in Global.mainMenuProducts)
            {
                itemForUserMainMenu newItem = new itemForUserMainMenu();
                product curProduct = Global.allProducts[item]; // The current product
                newItem.prdctPic.Image = curProduct.image;
                newItem.prdctName.Text = curProduct.Name;
                newItem.prdctPrice.Text = curProduct.Price.ToString();
                newItem.Product = curProduct;
                newItem.Click += new EventHandler(this.Item_click);
                newItem.TopLevel = false;
                productsMenu.Controls.Add(newItem);
            }
        }

        void Item_click(object sender, EventArgs e)
        {
            itemForUserMainMenu obj = (itemForUserMainMenu)sender;
            QuantityForm Qf = new QuantityForm();
            Global.currProduct = obj.Product;
            Qf.ShowDialog();
        }

        private void goToPayForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart checkout = new Cart();
            checkout.ShowDialog();
            this.Close();
        }
    }
}
