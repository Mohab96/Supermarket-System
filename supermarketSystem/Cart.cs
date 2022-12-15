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
            userMainMenu UMM=new userMainMenu();
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
                totalCashNeeded+=totalPrice;
                string viewPrice=totalPrice.ToString();
                string viewName = Name.ToString();
                viewName = viewName + "   ";
                string viewQuantity=quantity.ToString();
                viewQuantity = viewQuantity + "x   ";
                viewPrice = viewPrice + "   ";
                Object[] obj = new object[] { viewName,quantity,totalPrice };
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
            Global.currCustomer.CashBalance-=totalCashNeeded;
            showUserMainMenu();
        }
    }
}
