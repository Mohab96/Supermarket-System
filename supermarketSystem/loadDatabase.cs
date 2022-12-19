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
    public static class loadDatabase
    {
        public static void loadCustomers()
        {
            Global.customersIDs = Global.readFromFile(Global.fixedPathForAllCustomersIDs);
            foreach (string ID in Global.customersIDs)
            {
                string path = "CustomerID_" + ID + ".txt";
                List<string> data = Global.readFromFile(path);
                customer newCustomer = new customer(data[0], data[1], data[2], data[3], data[4], data[5], double.Parse(data[6]));
                Global.allCustomers[ID] = newCustomer;
                Global.usersCredentials[newCustomer.Email] = newCustomer.Password;
            }
        }

        public static void loadAdmins()
        {
            Global.adminsIDs = Global.readFromFile(Global.fixedPathForAllAdminsIDs);
            foreach (string ID in Global.adminsIDs)
            {
                string path = "AdminID_" + ID + ".txt";
                List<string> data = Global.readFromFile(path);
                admin newAdmin = new admin(data[0], data[1], data[2], data[3], data[4]);
                Global.allAdmins[ID] = newAdmin;
                Global.adminsCredentials[newAdmin.Email] = newAdmin.Password;
            }
        }

        public static DateTime formatDate(string date)
        {
            string m;
            string d;
            string y;
            string tmp = "";
            int c = 0;
            while (date[c] != '/')
            {
                tmp += date[c];
                c++;
            }
            m = tmp;
            c++;
            tmp = "";
            while (date[c] != '/')
            {
                tmp += date[c++];
            }
            d = tmp;
            tmp = "";
            c++;
            while (c < date.Length)
            {
                tmp += date[c++];
            }
            y = tmp;
            DateTime ret = new DateTime(int.Parse(y), int.Parse(m), int.Parse(d));
            return ret;
        }

        public static void loadProducts()
        {
            Global.productsIDs = Global.readFromFile(Global.fixedPathForAllProductsIDs);
            foreach (string ID in Global.productsIDs)
            {
                string path = "ProductID_" + ID + ".txt";
                List<string> data = Global.readFromFile(path);
                DateTime date = formatDate(data[5]);
                product newProduct = new product(data[0], int.Parse(data[1]), data[2], double.Parse(data[3]), int.Parse(data[4]), date, data[6]);
                Global.allProducts[ID] = newProduct;
                if (newProduct.Quantity >= 1)
                {
                    Global.mainMenuProducts.Add(ID);
                }
            }
        }

        public static void loadInvoices()
        {
            /// This method is for admins .. the customers have their invoices loaded in their constructors
            List<string> allInvoices = Global.readFromFile(Global.fixedPathForAllInvoicesIDs);

            foreach (var item in allInvoices)
            {
                string path = "InvoiceID_" + item + ".txt";
                List<string> data = Global.readFromFile(path);
                invoice newInvoice = new invoice(DateTime.Parse(data[0]), int.Parse(data[1]), data[2], int.Parse(data[3]), double.Parse(data[4]));
                Global.allInvoices[item] = newInvoice;
                Global.invoiceIDs.Add(item);
            }
        }
        public static void load()
        {
            loadCustomers();
            loadAdmins();
            loadProducts();
            loadInvoices();
        }
    }
}
