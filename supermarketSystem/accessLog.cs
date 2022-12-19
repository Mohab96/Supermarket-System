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
    public partial class accessLog : Form
    {
        public accessLog()
        {
            InitializeComponent();
        }

        private void accessLog_Load(object sender, EventArgs e)
        {
            // (mohab) => (joe) : You should iterate over Global.allInvoices to get the invoices (objects not strings)
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.currCustomer.CashBalance += int.Parse(numericUpDown1.Value.ToString());
            this.Close();
        }
    }
}
