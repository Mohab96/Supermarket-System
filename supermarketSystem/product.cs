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
        private PictureBox image;
        string imgUrl; /// (mohab) => (mas) : need this to be able to load the image when the databse loads

        /// (mohab) => (mas) : Finish the class with files and add the body of the setters 

        public product(string name, int quantity, double price, double discount, DateTime expirydate, string imgUrl)
        {
            /// (mohab) => (mas) : I removed picturebox from the parameters and added the url of the image to be able to load it form the files
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.expirydate = expirydate;
            this.imgUrl = imgUrl;

            /// (mohab) => (mas) : add update the files here
        }

        /// (mohab) => (mas) : add the body of the setters
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Expirydate { get; set; }
        public int Image { get; set; }

    }
}
