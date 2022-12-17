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
            this.displayPrice = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.checkout_ListBox = new System.Windows.Forms.ListBox();
            this.currCashInAcc = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayPrice
            // 
            this.displayPrice.AutoSize = true;
            this.displayPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrice.Location = new System.Drawing.Point(232, 485);
            this.displayPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayPrice.Name = "displayPrice";
            this.displayPrice.Size = new System.Drawing.Size(46, 29);
            this.displayPrice.TabIndex = 7;
            this.displayPrice.Text = "NA";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.Location = new System.Drawing.Point(35, 485);
            this.totalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(142, 29);
            this.totalPriceLbl.TabIndex = 6;
            this.totalPriceLbl.Text = "Total Price :";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(109, 543);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(172, 49);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // checkout_ListBox
            // 
            this.checkout_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_ListBox.FormattingEnabled = true;
            this.checkout_ListBox.ItemHeight = 20;
            this.checkout_ListBox.Location = new System.Drawing.Point(16, 63);
            this.checkout_ListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkout_ListBox.Name = "checkout_ListBox";
            this.checkout_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkout_ListBox.Size = new System.Drawing.Size(376, 404);
            this.checkout_ListBox.TabIndex = 0;
            this.checkout_ListBox.SelectedIndexChanged += new System.EventHandler(this.checkout_ListBox_SelectedIndexChanged);
            // 
            // currCashInAcc
            // 
            this.currCashInAcc.AutoSize = true;
            this.currCashInAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currCashInAcc.Location = new System.Drawing.Point(17, 16);
            this.currCashInAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currCashInAcc.Name = "currCashInAcc";
            this.currCashInAcc.Size = new System.Drawing.Size(80, 29);
            this.currCashInAcc.TabIndex = 8;
            this.currCashInAcc.Text = "Cash :";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(109, 20);
            this.balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(43, 26);
            this.balance.TabIndex = 9;
            this.balance.Text = "NA";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(293, 9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 38);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 607);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.currCashInAcc);
            this.Controls.Add(this.displayPrice);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.checkout_ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label currCashInAcc;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button backBtn;
    }
}