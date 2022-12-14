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
    public partial class update_product : Form
    {
        public product p ;

        public update_product()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = txtname.Text;
            p.Quantity = int.Parse(txtquan.Text);
            p.Price = double.Parse(txtprice.Text);
            p.image = pictureBox1.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            
        }

        private void update_product_Load(object sender, EventArgs e)
        {
            lbl_name.Text = p.Name;
            txtname.Text = p.Name;
            txtquan.Text = p.Quantity.ToString();           
            txtprice.Text = p.Price.ToString();
            pictureBox1.Image = p.image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagefile = new OpenFileDialog();
            imagefile.Title = "select an image";
            imagefile.Filter = "PNG Image |*png|BIK|*.bik";
            imagefile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if(imagefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = imagefile.FileName ;
            }

        }
    }
}
