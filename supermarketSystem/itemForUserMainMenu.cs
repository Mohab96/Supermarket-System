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
    public partial class itemForUserMainMenu : Form
    {
        public string dis
        {
            get { return lbldis.Text ; }
            set
            {
                if (int.Parse(value)> 0 )
                {
                    lbldis.Text = value; 
                }
                else
                {
                    lbldis.Visible = false ;
                    pictureBox1.Visible = false;
                }
            }
        }
             
        
        public itemForUserMainMenu()
        {
            InitializeComponent();
        }
        public product Product;
        public userMainMenu menu;

        private void btnadd_Click(object sender, EventArgs e)
        {
            Global.currProduct = this.Product;
            QuantityForm Qf = new QuantityForm();
            Qf.ShowDialog();
            this.menu.generateControls();
        }

        private void prdctPrice_Click(object sender, EventArgs e)
        {

        }

        private void prdctName_Click(object sender, EventArgs e)
        {

        }
    }
}
