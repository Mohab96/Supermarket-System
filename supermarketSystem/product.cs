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
        private string productname;
        private int quantity;
        private double price;
        private int discount;
        private DateTime expirydate;
        /// private PictureBox image;
        string imgUrl; /// (mas) => (mohab) : i dont understand this var

        /// (mohab) => (mas) : Finish the class with files and add the body of the setters 
        /// (mas) => (mohab) : خلصانه

        public product(string productname, int quantity, double price, int  discount, DateTime expirydate, string imgUrl)
        {
            /// (mohab) => (mas) : I removed picturebox from the parameters and added the url of the image to be able to load it form the files
            /// (mas) => (mohab) : هعديهالك المرادي
            this.productname = productname;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.expirydate = expirydate;
            this.imgUrl = imgUrl;

            string path = "productname_" + productname + ".txt";

            Global.writeOnFile(path, String.Empty);
            Global.writeOnFile(path, productname);
            Global.writeOnFile(path, quantity.ToString());
            Global.writeOnFile(path, price.ToString());
            Global.writeOnFile(path, discount.ToString());
            Global.writeOnFile(path, expirydate.ToString());
            Global.writeOnFile(path, imgUrl.ToString());
            


            /// (mas) => (mohab) : done ya 3tlaan
        }

        /// (mas) => (mohab) : i copied this fun "updateFile" from custmer class and make an edit on my copy
        /// because there are an erorr with updatefile  "updatefile dont declared"
        void updateFile(int idx, string val)
        {
            string path = "CustomerID_" + productname + ".txt";
            List<string> productdata = Global.readFromFile(path);
            productdata[idx] = val;
            Global.writeOnFile(path, String.Empty); // Clear the file before writing on it
            foreach (var item in productdata)
                Global.writeOnFile(path, item);
        }

        /// (mohab) => (mas) : add the body of the setters
        /// (mas) => (mohab) : ما قولنا خلصانه هو حوار 
        /// راجع بس كده على شغل الفايلز بتاعي 
        public string Name {
            get { return productname; }
            set
            {
                updateFile(0, value);
                productname = value;
            }
        }
        public int Quantity {
            get { return quantity; }
            set
            {
                updateFile(1, value.ToString());
                quantity = value;
            }
        }
        public double Price {
            get { return price; }
            set
            {
                updateFile(2, value.ToString());
                price = value;
            }
        }
        public int Discount
        {
            get { return discount; }
            set
            {
                updateFile(3, value.ToString());
                discount = value;
            }
        }
        public DateTime Expirydate {
            get { return expirydate; }
            set
            {
                updateFile(4, value.ToString());
                expirydate = value;
            }
        }

        /// (mas) => (mohab) : 
        public string Image
        {
            get { return imgUrl; }
            set
            {
                updateFile(5, value.ToString());
                imgUrl = value;
            }
        }

    }
}
