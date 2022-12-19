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
    public partial class invoice_form : Form
    {
        public invoice_form() 
        {
            InitializeComponent();
        }
        public double totalcashneeded =0;
        
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mohab96/Supermarket-System");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            textBox2.Text = DateTime.Now.ToString("dd/mm/yyy");
            label7.Text = Global.currCustomer.FullName;

            label12.Text = Global.currCustomer.cart.Count.ToString();
            foreach (var pro in Global.currCustomer.cart)
            {
                string Name = pro.Key.Name;
                int quantity = pro.Value;
                double totalPrice = (quantity * pro.Key.Price) * ((100 - pro.Key.Discount) / 100.0);
                totalcashneeded += totalPrice;
            }
            label13.Text = totalcashneeded.ToString();


            foreach (var item in Global.currCustomer.cart)
            {
                string name = item.Key.Name;
                string qun = item.Value.ToString();
                string price = item.Key.Price.ToString();

                double totalprice = int.Parse(qun) * double.Parse(price) * ((100 - item.Key.Discount) / 100.0);

                string tot = totalprice.ToString();

                object[] obj = new object[] { name, qun, price, tot };
                dataGridView1.Rows.Add(obj);
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;


            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            
            e.Graphics.DrawImage(Properties.Resources.Cart,margin, margin, 200, 200);

            string strdata = "Date : " + textBox2.Text;
            string strname = "name : " + label7.Text;
            SizeF FontSizeDate = e.Graphics.MeasureString(strdata, f);
            SizeF FontSizeName = e.Graphics.MeasureString(strname, f);

            e.Graphics.DrawString(strdata, f, Brushes.Black, e.PageBounds.Width - FontSizeDate.Width - margin, margin);
            e.Graphics.DrawString(strname, f, Brushes.Black, e.PageBounds.Width - FontSizeDate.Width - margin, margin+FontSizeDate.Height);
            float preHeight = margin + FontSizeDate.Height + FontSizeName.Height+150;
            e.Graphics.DrawRectangle(Pens.Black, margin, preHeight, e.PageBounds.Width - margin*2 , e.PageBounds.Height-margin -preHeight);
            float colHight = 60;

            float col1Width = 300;
            float col2Width = 125 + col1Width;
            float col3Width = 125 + col2Width;
            float col4Width = 125 + col3Width;



            e.Graphics.DrawLine(Pens.Black, margin, preHeight + colHight, e.PageBounds.Width-margin,preHeight+colHight);



            e.Graphics.DrawString("Total price", f, Brushes.Black, e.PageBounds.Width - margin*5, preHeight);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 5, preHeight, e.PageBounds.Width - margin * 5, e.PageBounds.Height - margin);
            e.Graphics.DrawString(" price", f, Brushes.Black, e.PageBounds.Width - margin * 10, preHeight);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 10, preHeight, e.PageBounds.Width - margin * 10, e.PageBounds.Height - margin);
            e.Graphics.DrawString("Quantity", f, Brushes.Black, e.PageBounds.Width - margin *15 , preHeight);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin *15 , preHeight, e.PageBounds.Width - margin * 15, e.PageBounds.Height - margin);
            e.Graphics.DrawString("Product", f, Brushes.Black, e.PageBounds.Width - margin * 19, preHeight);

            //////////////////////////////invoice content//////////////////////
            ///
            float rowsHight = 60;
            for (int x=0; x<dataGridView1.Rows.Count;x+=1)
            {
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2-col1Width,preHeight+rowsHight);

                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeight + rowsHight);

                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3Width, preHeight + rowsHight);

                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4Width, preHeight + rowsHight);

                e.Graphics.DrawLine(Pens.Black, margin, preHeight + rowsHight + col1Width, e.PageBounds.Width - margin, preHeight + rowsHight+col1Width);



                   
                rowsHight += 60;
            }

            e.Graphics.DrawString("Total", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col3Width, preHeight + rowsHight);

            e.Graphics.DrawString(label12.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col3Width, preHeight + rowsHight);

            e.Graphics.DrawLine(Pens.Black, margin, preHeight + rowsHight + col1Width, e.PageBounds.Width - margin, preHeight + rowsHight + col1Width);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void invoice_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
