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
        public product p;
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
    }
}
