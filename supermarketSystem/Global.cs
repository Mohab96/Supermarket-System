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
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(target);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
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

        public static List<string> customersIDs = new List<string>(); // The IDs of the files that store the data of the customers
        public static Hashtable allProducts = new Hashtable();
        public static Hashtable usersCredentials = new Hashtable();
        public static Hashtable allCustomers = new Hashtable();
        public static Hashtable allAdmins = new Hashtable();
        /// <issue>
        /// what should the size of this array be
        /// </issue>
        public static string[] readfromFile = new string[10000];
        public static long cashBalance;
        public static product[] mainMenuProducts = new product[10000];
    }
}
