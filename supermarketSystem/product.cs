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
    public class product
    {
        private string name;
        private int quantity;
        private double price;
        private double discount;
        private DateTime expirydate;
        private PictureBox image ;

        public product(string name ,int quantity , double price,double discount , DateTime expirydate, PictureBox image)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.expirydate = expirydate;
            this.image = image;
        }


        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Expirydate { get; set; }
        public int Image { get; set; } 

    }
}
