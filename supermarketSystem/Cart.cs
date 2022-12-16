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

        private void Cart_Load(object sender, EventArgs e)
        {
            balance.Text = Global.currCustomer.CashBalance.ToString();
            foreach (var pro in Global.currCustomer.cart)
            {
                string Name = pro.Key.Name;
                int quantity = pro.Value;
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
                /// (mohab) => (mostafa fouad) : If we have time add some verfications to these values 
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
            /// (mohab) => (mostafa fouad) : You forgot to update the Global.cashBalance with the money the user paid
            
            /// (mohab) => (mostafa fouad) : You forgot to update the quantity of the products the user bought
            
            /// (mohab) => (mostafa fouad) : We will need to show the invoice form after this form so don't forget 
            /// to open that form after the transaction is done (all of this will be done after the form is already 
            /// created ^_^)
            showUserMainMenu();
        }
    }
}
