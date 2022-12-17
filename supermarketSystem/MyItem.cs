using Org.BouncyCastle.Utilities.Collections;
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
    public partial class MyItem : UserControl
    {
        public MyItem()
        {
            InitializeComponent();
        }
        private Image _icon;
        private string _title;
        private string _price;
        public string id;
        public product Product;
        public adminMainMenu Menu;
        public bool empty = false;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbicon.Image = value; }
        }
        public string Tiltle
        {
            get { return _title; }
            set { _title = value; lbltitle.Text = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; lblprice.Text = value; }
        }

        private void MyItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MyItem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void MyItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Global.currProduct = this.Product;
            update_product UP = new update_product();
            UP.ShowDialog();
            this.Menu.Hide();
            this.Menu.Close();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            Global.currProduct = this.Product;
            buy_product_foradmin bp = new buy_product_foradmin();
            bp.ShowDialog();
        }
        public void add_item()
        {
            this.btnbuy.Enabled = false;
            this.btnedit.Enabled = false;
            this.btndel.Enabled = false;
            empty = true;
            this.Icon = supermarketSystem.Properties.Resources.more;
            this.pbicon.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Hand;
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            ///From JOE to Mohab :: how can i delete a product
            Global.allProducts.Remove(this.id);
            this.Menu.generatecontrols();
        }
        private void pbicon_Click(object sender, EventArgs e)
        {
            if(empty)
            {
                createProduct CP = new createProduct();
                CP.ShowDialog();
                this.Menu.Close();
            }
        }

        private void btnbuy_MouseEnter(object sender, EventArgs e)
        {
            btnbuy.BackColor = Color.SpringGreen;
        }

        private void btnbuy_MouseLeave(object sender, EventArgs e)
        {
            btnbuy.BackColor = Color.MediumSeaGreen;
        }

        private void btnedit_MouseEnter(object sender, EventArgs e)
        {
            btnedit.BackColor = Color.DarkCyan;
        }

        private void btnedit_MouseLeave(object sender, EventArgs e)
        {
            btnedit.BackColor = Color.Teal;
        }

        private void btndel_MouseLeave(object sender, EventArgs e)
        {
            btndel.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btndel_MouseEnter(object sender, EventArgs e)
        {
            
            btndel.BackColor = Color.FromArgb(234, 0, 0);
        }
    }
}
