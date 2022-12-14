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

        private void Cart_Load(object sender, EventArgs e)
        {
            foreach (var pro in Global.currCustomer.cart) 
            {
                string Name = pro.Key.Name;
                int quantity = pro.Value;
                double totalPrice = quantity * pro.Key.Price;
                string viewPrice=totalPrice.ToString();
                string viewName = Name.ToString();
                viewName = viewName + "   ";
                string viewQuantity=quantity.ToString();
                viewQuantity = viewQuantity + "x   ";
                viewPrice = viewPrice + "   ";
                Object[] obj = new object[] { viewName,quantity,totalPrice };
                checkout_ListBox.Items.AddRange(obj);
            }
        }
    }
}
