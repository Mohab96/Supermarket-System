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

        // Constructor 
        public admin(string fullName, string password, string email, string phoneNumber, string id)
        {
            this.fullName = fullName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.id = id;
            string path = "AdminID_" + this.id + ".txt";
            Global.writeOnFile(path, String.Empty);
            Global.writeOnFile(path, fullName);
            Global.writeOnFile(path, password);
            Global.writeOnFile(path, email);
            Global.writeOnFile(path, phoneNumber);
            Global.writeOnFile(path, id);
        }

        void updateFile(int idx, string val)
        {
            string path = "AdminID_" + this.id + ".txt";
            List<string> data = Global.readFromFile(path);
            data[idx] = val;
            Global.writeOnFile(path, String.Empty);
            foreach (var item in data)
                Global.writeOnFile(path, item);
        }

        // Properties 
        public string FullName
        {
            get { return fullName; }
            set
            {
                updateFile(0, value);
                fullName = value;
            }

        }
        public string Password
        {
            get { return password; }
            set
            {
                updateFile(1, value);
                password = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                updateFile(2, value);
                email = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                updateFile(3, value);
                phoneNumber = value;
            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                updateFile(4, value);
                id = value;
            }
        }

        // Methods
        public void updateDiscount(product p) { }
        public void updatePricing(product p) { }
        public void addProduct(product p) { }
        public void removeProduct(product p) { }
        public void createProduct(product p) { }
        public void buyProduct(product p, int cnt) { }
        public void editCash(double Money) { }
        public void accessLog() { }
    }
}
