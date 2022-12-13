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
    public partial class updateproduct : Form
    {
        public product b ; 

        public updateproduct()
        {
            InitializeComponent();
        }

        private void updateproduct_Load(object sender, EventArgs e)
        {
            lbl_name.Text = b.Name;
            txtname.Text = b.Name;
            txtquan.Text = b.Quantity.ToString() ;
            txtprice.Text = b.Price.ToString();
            pictureBox1.Image = b.image;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            b.Name = txtname.Text ;
            b.Quantity = int.Parse(txtquan.Text);
            b.Price = double.Parse(txtprice.Text) ;
            b.image = pictureBox1.Image ;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            lbl_name.Text = "Text box";
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
