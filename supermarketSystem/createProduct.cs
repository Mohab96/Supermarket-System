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
    public partial class createProduct : Form
    {
        string imagelocation = ""; // holding the location of the image of the product
        public createProduct()
        {
            InitializeComponent();
        }

        bool isValid(string Name, string quantity, string price)
        {
            return Name != String.Empty && quantity != String.Empty && price != String.Empty;

        }
        bool isValidQuantity(string quantity)
        {
            // checking the quantity srting 
            // valid if all the chracters in it are numbers
            for (int i = 0; i < quantity.Length; i++)
            {
                if (quantity[i] >= 48 && quantity[i] <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool isValidPrice(string price)
        {
            if (price.Length == 1 && price[0] == '0')
            {
                return false;
            }
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] >= 48 && price[i] <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool isVaildDate(string year, string month, string day)
        {
            // validating the Expire Date
            if (!isValid(year, month, day))
            {
                return false;
            }
            int currDay = int.Parse(day);
            int currYear = int.Parse(year);
            int currMonth = int.Parse(month);
            if (year.Length != 4 || currMonth > 12 || currMonth < 1 || currDay > 31 || currDay < 1)
            {
                return false;
            }
            if (month == "11" || month == "9" || month == "6" || month == "4" && currDay > 30)
            {
                return false;
            }
            if (month == "2" && currDay > 28)
            {
                return false;
            }
            if (DateTime.Now.Year > currYear)
            {
                return false;
            }
            if (DateTime.Now.Month > currMonth && currYear == DateTime.Now.Year)
            {
                return false;
            }
            if (DateTime.Now.Day > currDay && currYear == DateTime.Now.Year && currDay == DateTime.Now.Day)
            {
                return false;
            }
            return true;
        }

        int cutOff(string discount, double price)
        {
            // this will return the discount after is checked
            if (discount == string.Empty)
            {
                return 0;
            }
            for (int i = 0; i < discount.Length; i++)
            {
                if (discount[i] >= 48 && discount[i] <= 57)
                {
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            int dis = int.Parse(discount);
            if (dis > 100 || dis <= 0)
            {
                return 0;
            }
            return dis;


        }

        void showAdminMainMenu()
        {
            this.Hide();
            adminMainMenu admin = new adminMainMenu();
            admin.ShowDialog();
            this.Close();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog cin = new OpenFileDialog();
                cin.Filter = "image|*.jpg;*.png;*.bmp";
                if (cin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = cin.FileName;
                    productImage.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a supported file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void addToAdminMainMenu()
        {
            adminMainMenu admin = new adminMainMenu();
            admin.generatecontrols();
            /// (mohab) => (mostafa fouad) : I think that you add it in Global.allProducts only and joe will do the rest
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // not fully completed

            // fetching the information
            string Name = nameTxtBx.Text;
            string quantity = quantityTxtBx.Text;
            string price = priceTxtBx.Text;
            string year = yearTxtBx.Text;
            string day = dayTxtBx.Text;
            string month = monthTxtBx.Text;
            string discount = discountTxtBx.Text;

            // checking if there are any incomplete info 
            if (isValid(Name, quantity, price) && imagelocation != "")
            {
                if (isValidQuantity(quantity) && isValidPrice(price) && isVaildDate(year, month, day))
                {
                    /// (mohab) => (mostafa fouad) : You need to handle the ID as I told you
                    double currprice = double.Parse(price);
                    int dis = cutOff(discount, currprice);
                    int quan = int.Parse(quantity);
                    int y = int.Parse(year);
                    int m = int.Parse(month);
                    int d = int.Parse(day);
                    DateTime expire = new DateTime(y, m, d);
                    // creating a new product
                    product newProduct = new product(Name, quan, "20", currprice, dis, expire, imagelocation);
                    // add it to data structure 
                    Global.allProducts.Add("20", newProduct);
                    // add it to the admin main menu
                    addToAdminMainMenu();
                    MessageBox.Show("Product added successfully", "Done");
                    // show the admin main menu
                    showAdminMainMenu();
                    return;
                }
            }

            MessageBox.Show("Please fill all the information correctly ", "Error");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //return back to the admin main menu
            showAdminMainMenu();
        }
    }
}
