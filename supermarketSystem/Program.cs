using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace supermarketSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // Global variables start here

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

        // Global variables end here

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
