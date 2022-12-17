using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarketSystem
{
    class loadDatabase
    {
        void loadCustomers()
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

        void loadAdmins()
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

        void loadProducts()
        {
            Global.productsIDs = Global.readFromFile(Global.fixedPathForAllProductsIDs);
            foreach (string ID in Global.productsIDs)
            {
                string path = "ProductID_" + ID + ".txt";
                List<string> data = Global.readFromFile(path);
                product newProduct = new product(data[0], int.Parse(data[1]), data[2], double.Parse(data[3]), int.Parse(data[4]), DateTime.Parse(data[4]), data[5]);
                Global.allProducts[ID] = newProduct;
            }
        }

        void loadInvoices()
        {
            /// This method is for admins .. the customers have their invoices loaded in their constructors
            List<string> allInvoices = Global.readFromFile(Global.fixedPathForAllInvoicesIDs);

            foreach (var item in allInvoices)
                Global.invoiceIDs.Add(item);
        }

        public loadDatabase()
        {
            loadCustomers();
            loadAdmins();
            loadProducts();
            loadInvoices();
        }
    }
}
