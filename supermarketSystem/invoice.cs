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
        List<product> productlist ;  
        // List<int,product> productlist
        private int tax;
        private string id;
        private int discountPer;
        private double totalprice;

        public invoice(DateTime date , int tax , string id , int discountPer , double totalprice)
        {
            this.date = date;
            this.productlist = new List<product>() ;
            this.tax = tax;
            this.id= id;
            this.discountPer = discountPer ;
            this.totalprice = totalprice;

            string path = "invoice id : " + id + ".txt";
            Global.writeOnFile(path, String.Empty);
            Global.writeOnFile(path, date.ToString());
            Global.writeOnFile(path, tax.ToString());
            Global.writeOnFile(path, id.ToString());
            Global.writeOnFile(path, discountPer.ToString());
            Global.writeOnFile(path, totalprice.ToString());

            foreach (product p in productlist)
            { Global.writeOnFile(path, p.ToString() ); }

        }
        /// (mohab) => (mas) : Add the constructor and format the text file in the same constructor
        /// (mohab) => (mas) : Add the products list
        /// (mohab) => (mas) : Add the method that download the invoice as pdf file

        public void DownloadFile(Uri address, string fileName)
        {

        }
        

        ///(mas) => (team) : 
        ///1- how can i init. list with two Parameter..note:C# doesn't have built-in Map 

        /// 2- download file  : with my search i found this way but i dont understand it totaly
    }
}
