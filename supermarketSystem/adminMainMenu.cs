using iTextSharp.text.pdf.qrcode;
using supermarketSystem.Properties;
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
        }

        public void generatecontrols()
        {
            flowLayoutPanel1.Controls.Clear();
            if (Global.allProducts.Count > 0)
            {
                int n = Global.allProducts.Count;
                MyItem[] item = new MyItem[n];
                int i = 0;
                foreach (KeyValuePair<string, product> de in Global.allProducts)
                {
                    item[i] = new MyItem();
                    item[i].Icon = de.Value.image;
                    item[i].Name = de.Value.Name;
                    item[i].Price = de.Value.Price.ToString();
                    item[i].Product = de.Value;
                    item[i].id = (string)de.Key;
                    item[i].Menu = this;
                    flowLayoutPanel1.Controls.Add(item[i]);
                    i++;
                }
            }
            MyItem add = new MyItem();
            add.add_item();
            add.Menu = this;
            flowLayoutPanel1.Controls.Add(add);
            add.Click += new System.EventHandler(this.MyItem_click);
        }
        void MyItem_click(object sender, EventArgs e)
        {           
            createProduct CP = new createProduct();          
            CP.ShowDialog();
            this.Close();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminMainMenu_Load(object sender, EventArgs e)
        {
            generatecontrols();
            lblcash.Text = Global.cashBalance.ToString();
            lblname.Text = Global.currAdmin.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            accessLog al = new accessLog();
            al.ShowDialog();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            Global.currAdmin = null;
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {

        }
    }
}
