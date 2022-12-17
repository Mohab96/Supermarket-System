using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarketSystem
{
    public static class Global
    {
        public static void writeOnFile(string fileName, string target)
        {
            // Write the string target in the file fileName
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(target);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
        public static List<string> readFromFile(string fileName)
        {
            // Get the contents of the file fileName

            List<string> file = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        file.Add(line);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return file;
        }
        public static void clearFile(string path)
        {
            File.WriteAllText(path, string.Empty);
        }

        public static string fixedPathForAllCustomersIDs = "AllCusomersIDs.txt";
        public static string fixedPathForAllAdminsIDs = "AllAdminsIDs.txt";
        public static string fixedPathForAllProductsIDs = "AllProductsIDs.txt";
        public static string fixedPathForAllInvoicesIDs = "AllInvoicesIDs.txt";
        public static string fixedPathForGeneralID = "GeneralID.txt";

        public static admin currAdmin;  // holds the admin object that currently signed in
        public static customer currCustomer;  // holds the customer object that currently signed in
        public static product currProduct; // holds the product clicked

        public static List<string> customersIDs = new List<string>(); // The IDs of the files that store the data of the customers
        public static List<string> adminsIDs = new List<string>(); // The IDs of the files that store the data of the admins
        public static List<string> productsIDs = new List<string>(); // The IDs of the files that store the data of the products
        public static List<string> invoiceIDs = new List<string>(); // The IDs of the files that store the invoices

        public static Dictionary<string,product> allProducts = new Dictionary<string, product>(); // id, product
        //public static Hashtable allProducts = new Hashtable(); // id, product
        public static Dictionary<string, customer> allCustomers = new Dictionary<string, customer>(); // id, customer
        //public static Hashtable allCustomers = new Hashtable(); // id, customer
        public static Dictionary<string, admin> allAdmins = new Dictionary<string, admin>(); // id, admin
        //public static Hashtable allAdmins = new Hashtable(); // id, admin


        public static Hashtable usersCredentials = new Hashtable(); // email, password
        public static Hashtable adminsCredentials = new Hashtable(); // email, password

        public static double cashBalance;
        public static List<string> mainMenuProducts = new List<string>(); // ID of the product .. if you want to access it use allProducts
    }
}
