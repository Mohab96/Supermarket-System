﻿namespace supermarketSystem
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
            this.displayPrice = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.checkout_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // displayPrice
            // 
            this.displayPrice.AutoSize = true;
            this.displayPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrice.Location = new System.Drawing.Point(214, 377);
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
            this.totalPriceLbl.Location = new System.Drawing.Point(43, 377);
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
            this.checkoutBtn.Location = new System.Drawing.Point(82, 441);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(129, 40);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // checkout_ListBox
            // 
            this.checkout_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_ListBox.FormattingEnabled = true;
            this.checkout_ListBox.ItemHeight = 16;
            this.checkout_ListBox.Items.AddRange(new object[] {
            "Border Style Will be Changed Later :D"});
            this.checkout_ListBox.Location = new System.Drawing.Point(12, 15);
            this.checkout_ListBox.Name = "checkout_ListBox";
            this.checkout_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkout_ListBox.Size = new System.Drawing.Size(277, 340);
            this.checkout_ListBox.TabIndex = 0;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.displayPrice);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.checkout_ListBox);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.ListBox checkout_ListBox;
        private System.Windows.Forms.Label displayPrice;
        private System.Windows.Forms.Label totalPriceLbl;
    }
}