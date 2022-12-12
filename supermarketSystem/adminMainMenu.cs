using System;
using System.Collections;
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
    public partial class adminMainMenu : Form
    {
        public adminMainMenu()
        {
            InitializeComponent();
            generatecontrols();
        }
        public void generatecontrols()
        {

            flowLayoutPanel1.Controls.Clear();
            int n = Global.allProducts.Count;
            MyItem[] item = new MyItem[n];
            int i = 0;
            foreach (KeyValuePair<string, product> de in Global.allProducts)
            {
                item[i] = new MyItem();
                item[i].Icon = de.Value.image;
                item[i].Name = de.Value.Name;
                item[i].Price = de.Value.Price.ToString();
                item[i].p = de.Value;
                item[i].id = (string)de.Key;
                flowLayoutPanel1.Controls.Add(item[i]);
                item[i].Click += new System.EventHandler(this.MyItem_click);
                i++;
            }
        }
        void MyItem_click(object sender, EventArgs e)
        {
            MyItem obj = (MyItem)sender;
            ///send this obj to the update form and and open it
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminMainMenu_Load(object sender, EventArgs e)
        {
            lblname.Text = Global.currAdmin.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///show add form
        }
    }
}
