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
    public partial class Cart : Form
    {

        public Cart()
        {
            InitializeComponent();
        }
        double totalCashNeeded = 0;
        void showUserMainMenu()
        {
            this.Hide();
            userMainMenu UMM = new userMainMenu();
            UMM.ShowDialog();
            this.Hide();
        }

        void updateQuantity()
        {
            // updating the quantity of the current product 
            foreach (var pro in Global.currCustomer.cart)
            {
                string currID = pro.Key.Id;
                int quantity = pro.Value;
                Global.allProducts[currID].Quantity -= quantity;
            }
        }

        int checkCurrQuantity(string procutID,int quantity)
        {
            return Math.Min(Global.allProducts[procutID].Quantity, quantity);
            // for example if the customer bought two Pieces of product X and the quantity of X is 1 
            // then the customer will not be able to buy two Pieces but he can buy 1 instead 
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            if (Global.currCustomer.cart.Count == 0) 
            {
                // if the customer did not buy anyting
                MessageBox.Show("Your cart is empty");
                checkoutBtn.Enabled = false;
                return;
            }
            balance.Text = Global.currCustomer.CashBalance.ToString();
            foreach (var pro in Global.currCustomer.cart)
            {
                string Name = pro.Key.Name;

                int quantity = pro.Value;

                quantity = checkCurrQuantity(pro.Key.Id, quantity); 

                double totalPrice = quantity * pro.Key.Price;

                totalCashNeeded += totalPrice;

                string viewPrice = totalPrice.ToString();

                string viewName = Name.ToString();

                viewName = viewName + "   ";

                string viewQuantity = quantity.ToString();

                viewQuantity = viewQuantity + "x   ";

                viewPrice = viewPrice + "   ";

                Object[] obj = new object[] { viewName, quantity, totalPrice };

                checkout_ListBox.Items.AddRange(obj);

            }
            displayPrice.Text = totalCashNeeded.ToString(); // showing the total price 
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (totalCashNeeded > Global.currCustomer.CashBalance)
            {
                MessageBox.Show("Sorry you don't have enough cash");
                return;
            }
            MessageBox.Show("Products have bought successfully", "Done");
            Global.currCustomer.CashBalance -= totalCashNeeded;
            Global.cashBalance = totalCashNeeded;
            updateQuantity(); // updating the quantity of all bought items
            
            /// (mohab) => (mostafa fouad) : We will need to show the invoice form after this form so don't forget 
            /// to open that form after the transaction is done (all of this will be done after the form is already 
            /// created ^_^)
            showUserMainMenu();
        }
    }
}
