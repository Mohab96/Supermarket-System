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

        bool IsValid(string name, int quantity, double price)
        {
            if (name == String.Empty || quantity.ToString() == String.Empty || price.ToString() == String.Empty)
            {
                return false;
            }
            else
                return true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtname.Text, int.Parse(txtquan.Text), double.Parse(txtprice.Text)))
            {
                MessageBox.Show("Please fill all the informatin correctly");
            }
            else if (int.Parse(txtquan.Text) == 0 || int.Parse(txtprice.Text) == 0)
                MessageBox.Show("Please fill all the informatin correctly");
            else
            {
                Global.currProduct.Name = txtname.Text;
                if (Global.currProduct.Quantity == 0) Global.mainMenuProducts.Add(Global.currProduct.Id);
                Global.currProduct.Quantity = int.Parse(txtquan.Text);
                Global.currProduct.Price = double.Parse(txtprice.Text);
                Global.currProduct.Image = pictureBox1.ImageLocation;
                MessageBox.Show("Done.. The data has been updated");

                this.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void update_product_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Global.currProduct.Name;
            txtname.Text = Global.currProduct.Name;
            txtquan.Text = Global.currProduct.Quantity.ToString();
            txtprice.Text = Global.currProduct.Price.ToString();
            pictureBox1.ImageLocation = Global.currProduct.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagefile = new OpenFileDialog();
                imagefile.Title = "select an image";
                imagefile.Filter = "image|*.jpg;*.png;*.bmp";
                imagefile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (imagefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.ImageLocation = imagefile.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a supported file");
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtquan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
