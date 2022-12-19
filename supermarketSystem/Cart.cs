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
        public userMainMenu menu;
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

        int checkCurrQuantity(string procutID, int quantity)
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
            balance.Text += '$';
            foreach (var pro in Global.currCustomer.cart)
            {
                string Name = pro.Key.Name;

                int quantity = pro.Value;

                quantity = checkCurrQuantity(pro.Key.Id, quantity);

                double totalPrice = (quantity * pro.Key.Price) * ((100 - pro.Key.Discount) / 100.0);

                totalCashNeeded += totalPrice;

                string viewPrice = totalPrice.ToString();

                string viewName = Name.ToString();

                viewName = viewName + "   ";

                string viewQuantity = quantity.ToString();

                viewQuantity = viewQuantity + "X   ";

                viewPrice = viewPrice + "   ";
                string tot = viewName + viewQuantity + totalPrice+'$';


                checkout_ListBox.Items.Add(tot);
                checkout_ListBox.Items.Add("-----------------------");

            }
            displayPrice.Text = totalCashNeeded.ToString(); // showing the total price
            displayPrice.Text += '$';
        }

        int currID()
        {
            List<string> generalIdFile = Global.readFromFile(Global.fixedPathForGeneralID);
            int generalID = generalIdFile.Count == 0 ? 22 : int.Parse(generalIdFile[0]);
            generalID += 213;
            Global.clearFile(Global.fixedPathForGeneralID);
            Global.writeOnFile(Global.fixedPathForGeneralID, generalID.ToString());
            return generalID;
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
            int ID = currID();

            invoice inv = new invoice(DateTime.Now, 0, ID.ToString(), 0, totalCashNeeded);
            Global.invoiceIDs.Add(ID.ToString());
            Global.currInvoice = inv;

            //showUserMainMenu();
            this.Hide();
            invoice_form i_f = new invoice_form();
            i_f.Show();
            this.menu.close = false;
            this.menu.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //userMainMenu UMM =new userMainMenu();
            //UMM.ShowDialog();
            this.Close();
        }

        private void checkout_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
