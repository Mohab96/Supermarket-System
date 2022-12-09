﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarketSystem
{
    class customer
    {
        string fullName, password, email, phoneNumber, address, id;
        double cashBalance;
        List<Tuple<string, int>> cart = new List<Tuple<string, int>>(); // product id and quantity
        List<string> invoicesIDs = new List<string>(); // all invoices for this customer (it was purchaseLog)

        public customer(string fullName, string password, string email,
            string phoneNumber, string address, string id, double cashBalance)
        {
            this.fullName = fullName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.id = id;
            this.cashBalance = cashBalance;

            string path = "CustomerID_" + id + ".txt";
            Global.writeOnFile(path, String.Empty); // Clear the file before writing on it
            Global.writeOnFile(path, fullName);
            Global.writeOnFile(path, password);
            Global.writeOnFile(path, email);
            Global.writeOnFile(path, phoneNumber);
            Global.writeOnFile(path, address);
            Global.writeOnFile(path, id);
            Global.writeOnFile(path, cashBalance.ToString());

            path = "invoicesIDs_" + id + ".txt";
            invoicesIDs = Global.readFromFile(path);
        }

        void updateFile(int idx, string val)
        {
            string path = "CustomerID_" + id + ".txt";
            List<string> data = Global.readFromFile(path);
            data[idx] = val;
            Global.writeOnFile(path, String.Empty); // Clear the file before writing on it
            foreach (var item in data)
                Global.writeOnFile(path, item);
        }

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

        public string Address
        {
            get { return address; }
            set
            {
                updateFile(4, value);
                address = value;
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                updateFile(5, value);
                id = value;
            }
        }

        public double CashBalance
        {
            get { return cashBalance; }
            set
            {
                updateFile(6, value.ToString());
                cashBalance = value;
            }
        }

        public void addToCart(string productId)
        {
            // form to take the quantity of that product
        }

        public void proceedToCheckout()
        {
            // Pay form
        }

        public void customerMainMenu()
        {
            // User main menu form
        }
    }
}