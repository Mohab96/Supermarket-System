using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarketSystem
{
    public class admin
    {
        // Declaration 
        string fullName;
        string password;
        string email;
        string phoneNumber;
        string id;

        // Properties 
        public string FullName
        { 
            get { return fullName; }
            set { fullName = value; }

        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber 
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Id 
        {
            get { return id; }
            set { id = value; }
        }

        // Methods

        // to do 
        // public void updateDiscount(product p) { }
        // public void updatePricing(product p) { }
        // public void addProduct(product p) { }
        // public void removeProduct(product p) { }
        // public void createProduct() { }
        // public void buyProduct() { } 
        public void editCash(double Money) { }
        public void accessLog() { }
    }
}
