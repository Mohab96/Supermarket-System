using System;
using System.Collections.Generic;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketSystem
{
    public class invoice
    {
        private DateTime date;
        List<Tuple<int,string>> productlist ;  /// int quantity  string id
        private int tax;
        private string id;
        private int discountPer;
        private double totalprice;
        /// method : format invoice 
        /// method : download file

        public invoice(DateTime date , int tax , string id , int discountPer , double totalprice)
        {
            this.date = date;
            this.productlist = new List<Tuple<int,string>>() ;
            this.tax = tax;
            this.id= id;
            this.discountPer = discountPer; 
            this.totalprice = totalprice;

            string path = "InvoiceID_" + id + ".txt";
            Global.writeOnFile(path, String.Empty);
            Global.writeOnFile(path, date.ToString());
            Global.writeOnFile(path, tax.ToString());
            Global.writeOnFile(path, id.ToString());
            Global.writeOnFile(path, discountPer.ToString());
            Global.writeOnFile(path, totalprice.ToString());

            foreach (Tuple<int,string> p in productlist)
            {
                Global.writeOnFile(path, p.Item1.ToString());
                Global.writeOnFile(path, p.Item2);
            }
            /// write on file the quantity and id with loop >> done
        }

        void updateFile(int idx, string val)
        {
            string path = "InvoiceID_" + id + ".txt";
            List<string> invoicedata = Global.readFromFile(path);
            invoicedata[idx] = val;
            Global.writeOnFile(path, String.Empty); // Clear the file before writing on it
            foreach (var item in invoicedata)
                Global.writeOnFile(path, item);
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                updateFile(0, value.ToString());
                date = value;
            }
        }
        public int Tax
        {
            get { return tax; }
            set
            {
                updateFile(1, value.ToString());
                tax = value;
            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                updateFile(2, value);
                id = value;
            }
        }
        public int DiscountPer
        {
            get { return discountPer; }
            set
            {
                updateFile(3, value.ToString());
                discountPer = value;
            }
        }
        public double Totalprice
        {
            get { return totalprice; }
            set
            {
                updateFile(4, value.ToString());
                totalprice = value;
            }
        }




        public void downloadfile()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                
                file.ShowDialog();
                
                ///txtInput.Text = file.FileName;
            }

            ///txtOutput.Text = (txtInput.Text).Replace(".txt", ".pdf");

        }




    }
}
