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

        product CurProduct;
        List<itemForUserMainMenu> mainMenuProducts = new List<itemForUserMainMenu>();
        private void userMainMenu_Load(object sender, EventArgs e)
        {
            name.Text = Global.currCustomer.FullName;
            money.Text = Global.currCustomer.CashBalance.ToString() + "LE.";
            foreach (var item in Global.mainMenuProducts)
            {
                itemForUserMainMenu newItem = new itemForUserMainMenu();
                product curProduct = Global.allProducts[item]; // The current product
                CurProduct = curProduct;
                newItem.prdctPic.Image = curProduct.image;
                newItem.prdctName.Text = curProduct.Name;
                newItem.prdctPrice.Text = curProduct.Price.ToString();

                newItem.Click += new EventHandler(this.Item_click);
                newItem.TopLevel = false;
                mainMenuProducts.Add(newItem);
            }
        }

        void Item_click(object sender, EventArgs e)
        {
            product obj = CurProduct;
            QuantityForm Qf = new QuantityForm();
            Qf.ShowDialog();
            /// Send the object obj to the quantity form to decide the desired quantity 
            /// Uncle JOE will decide how this part will be completed ^_^
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
