namespace supermarketSystem
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.displayPrice = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.total_Label = new System.Windows.Forms.Label();
            this.quantity_Label = new System.Windows.Forms.Label();
            this.product_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkout_ListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.displayPrice);
            this.splitContainer1.Panel2.Controls.Add(this.totalPriceLbl);
            this.splitContainer1.Panel2.Controls.Add(this.checkoutBtn);
            this.splitContainer1.Panel2.Controls.Add(this.total_Label);
            this.splitContainer1.Panel2.Controls.Add(this.quantity_Label);
            this.splitContainer1.Panel2.Controls.Add(this.product_Label);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.checkout_ListBox);
            this.splitContainer1.Size = new System.Drawing.Size(875, 499);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // displayPrice
            // 
            this.displayPrice.AutoSize = true;
            this.displayPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrice.Location = new System.Drawing.Point(162, 371);
            this.displayPrice.Name = "displayPrice";
            this.displayPrice.Size = new System.Drawing.Size(37, 24);
            this.displayPrice.TabIndex = 7;
            this.displayPrice.Text = "NA";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.Location = new System.Drawing.Point(7, 371);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(109, 24);
            this.totalPriceLbl.TabIndex = 6;
            this.totalPriceLbl.Text = "Total Price :";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(82, 447);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(129, 40);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.BackColor = System.Drawing.Color.IndianRed;
            this.total_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.total_Label.Location = new System.Drawing.Point(239, 31);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(40, 17);
            this.total_Label.TabIndex = 4;
            this.total_Label.Text = "Total";
            // 
            // quantity_Label
            // 
            this.quantity_Label.AutoSize = true;
            this.quantity_Label.BackColor = System.Drawing.Color.IndianRed;
            this.quantity_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quantity_Label.Location = new System.Drawing.Point(150, 31);
            this.quantity_Label.Name = "quantity_Label";
            this.quantity_Label.Size = new System.Drawing.Size(61, 17);
            this.quantity_Label.TabIndex = 3;
            this.quantity_Label.Text = "Quantity";
            // 
            // product_Label
            // 
            this.product_Label.AutoSize = true;
            this.product_Label.BackColor = System.Drawing.Color.IndianRed;
            this.product_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.product_Label.Location = new System.Drawing.Point(20, 31);
            this.product_Label.Name = "product_Label";
            this.product_Label.Size = new System.Drawing.Size(57, 17);
            this.product_Label.TabIndex = 2;
            this.product_Label.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 47);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkout_ListBox
            // 
            this.checkout_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_ListBox.FormattingEnabled = true;
            this.checkout_ListBox.ItemHeight = 16;
            this.checkout_ListBox.Items.AddRange(new object[] {
            "Border Style Will be Changed Later :D"});
            this.checkout_ListBox.Location = new System.Drawing.Point(11, 65);
            this.checkout_ListBox.Name = "checkout_ListBox";
            this.checkout_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkout_ListBox.Size = new System.Drawing.Size(277, 276);
            this.checkout_ListBox.TabIndex = 0;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 499);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label quantity_Label;
        private System.Windows.Forms.Label product_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox checkout_ListBox;
        private System.Windows.Forms.Label displayPrice;
        private System.Windows.Forms.Label totalPriceLbl;
    }
}