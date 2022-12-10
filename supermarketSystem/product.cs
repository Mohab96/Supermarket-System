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
        private string id ;
        private double price;
        private int discount;
        private DateTime expirydate;
        private PictureBox image;
        string imgUrl; 

       

        public product(string productname, int quantity,string id , double price, int  discount, DateTime expirydate, string imgUrl)
        {
           
            this.productname = productname;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.expirydate = expirydate;
            this.imgUrl = imgUrl; ///method : take url and put the pic in pic box

            string path = "ProductID_" + id + ".txt";

            Global.writeOnFile(path, String.Empty);
            Global.writeOnFile(path, productname);
            Global.writeOnFile(path, quantity.ToString());
            Global.writeOnFile(path, price.ToString());
            Global.writeOnFile(path, discount.ToString());
            Global.writeOnFile(path, expirydate.ToString());
            Global.writeOnFile(path, imgUrl.ToString());
            

        }

        
        void updateFile(int idx, string val)
        {
            string path = "ProductID_" + id + ".txt";
            List<string> productdata = Global.readFromFile(path);
            productdata[idx] = val;
            Global.writeOnFile(path, String.Empty); // Clear the file before writing on it
            foreach (var item in productdata)
                Global.writeOnFile(path, item);
        }

         
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
        public string Id {
        get { return id; }
            set
            {
                updateFile(2, value);
            }
           }
        public double Price {
            get { return price; }
            set
            {
                updateFile(3, value.ToString());
                price = value;
            }
        }
        public int Discount
        {
            get { return discount; }
            set
            {
                updateFile(4, value.ToString());
                discount = value;
            }
        }
        public DateTime Expirydate {
            get { return expirydate; }
            set
            {
                updateFile(5, value.ToString());
                expirydate = value;
            }
        }

     
        public string Image
        {
            /// search about this 
            get { return imgUrl; }
            set
            {
                updateFile(6, value);
                imgUrl = value;
            }
        }

    }
}
