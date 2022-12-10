using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace supermarketSystem
{
    public class invoice
    {
        private DateTime date;
        List<Tuple<int,string>> productlist ;  /// int=> quantity  string id
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

            foreach ( Tuple<int,string> p in productlist)
            { }
            /// write on file the quantity and id with loop
        }
        




        public void DownloadFile(Uri address, string fileName)
        {

        }
       
        

       
    }
}
