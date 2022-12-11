using System;
using System.Collections.Generic;
using System.IO;
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
        /// method : invoice format 
        /// method : download file >> done 

        public invoice(DateTime date , int tax , string id , int discountPer , double totalprice)
        {
            this.date = date;
            this.productlist = new List<Tuple<int,string>>() ;
            this.tax = tax;
            this.id= id;
            this.discountPer = discountPer; 
            this.totalprice = totalprice;

            string path = "InvoiceID_" + id + ".txt";
            Global.clearFile(path);
            Global.writeOnFile(path, date.ToString());
            Global.writeOnFile(path, tax.ToString());
            Global.writeOnFile(path, id.ToString());
            Global.writeOnFile(path, discountPer.ToString());
            Global.writeOnFile(path, totalprice.ToString());

            string Quan_path = "QuantityID_" + id + ".txt";
            foreach (Tuple<int,string> p in productlist)
            {
                Global.writeOnFile(Quan_path, p.Item1.ToString());
                Global.writeOnFile(path, p.Item2);
                /// (mohab)=>(mas) : There is a problem here .. these two line write different data 
                /// on the same file .. Create a path for the quantity and another one for the ID 

            }
            /// write on file the quantity and id with loop >> done
        }

        void updateFile(int idx, string val)
        {
            string path = "InvoiceID_" + id + ".txt";
            List<string> invoicedata = Global.readFromFile(path);
            invoicedata[idx] = val;
            Global.clearFile(path); // Clear the file before writing on it
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




        private void create_pdf_file(customer c , invoice i )
        {
            string filepath = "InvoiceID_" + c.Id + i.Id + ".txt" ;

            filepath = filepath.Replace(".txt", ".pdf");

            StreamReader rdr = new StreamReader(filepath);
            Document d = new Document();

            PdfWriter.GetInstance(d, new FileStream(filepath, FileMode.Create));

            d.Open();

            d.Add(new Paragraph(rdr.ReadToEnd()));
            d.Close();

            MessageBox.Show("creating your pdf....");

            System.Diagnostics.Process.Start(filepath);
        }




    }
}
