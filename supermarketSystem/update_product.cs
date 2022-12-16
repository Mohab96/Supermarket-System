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
            Global.currProduct.Name = txtname.Text;
            Global.currProduct.Quantity = int.Parse(txtquan.Text);
            Global.currProduct.Price = double.Parse(txtprice.Text);
            Global.currProduct.image = pictureBox1.Image;
            adminMainMenu menu = new adminMainMenu();
            menu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMainMenu menu = new adminMainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            
        }

        private void update_product_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Global.currProduct.Name;
            txtname.Text = Global.currProduct.Name;
            txtquan.Text = Global.currProduct.Quantity.ToString();           
            txtprice.Text = Global.currProduct.Price.ToString();
            pictureBox1.Image = Global.currProduct.image;    
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
