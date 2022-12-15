using System;
using System.IO;
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
    public partial class buy_product_foradmin : Form
    {
        public buy_product_foradmin()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buy_product_foradmin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Font = this.Font;
            f.Icon = this.Icon;
            f.Size = this.Size;
            f.Height += 300;
            f.AutoScroll = true;
            int top = 10;
            try
            {
                StreamReader sr = new StreamReader("AllProductsIDs.txt");
                string line = "";
                do
                {
                    line = sr.ReadLine();
                    TextBox txt = new TextBox();
                    PictureBox pic = new PictureBox();
                    txt.Width = 200;
                    txt.Top = top ;
                    
                    pic.Left = 210;
                    pic.Top = top;
                    pic.Size = new Size(150, 150);

                    top += 155;

                } while (line != null);

            }
            catch { }
        }
    }
}
