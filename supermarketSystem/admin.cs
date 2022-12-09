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
            string path = "AdminID_" + this.id;
            Program.writeOnFile(path, fullName);
            Program.writeOnFile(path, password);
            Program.writeOnFile(path, email);
            Program.writeOnFile(path, phoneNumber);
            Program.writeOnFile(path, id);
        }
        void updateFile(int idx, string val)
        {
            string path = "AdminID_" + this.id;
            List<string> data = Program.readFromFile(path);
            data[idx] = val;
            foreach (var item in data)
                Program.writeOnFile(path, item);
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
