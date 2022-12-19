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
            this.displayPrice.ForeColor = System.Drawing.Color.Green;
            this.displayPrice.Location = new System.Drawing.Point(141, 394);
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
            this.totalPriceLbl.Location = new System.Drawing.Point(26, 394);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(109, 24);
            this.totalPriceLbl.TabIndex = 6;
            this.totalPriceLbl.Text = "Total Price :";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(82, 441);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(129, 40);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // checkout_ListBox
            // 
            this.checkout_ListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkout_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkout_ListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_ListBox.FormattingEnabled = true;
            this.checkout_ListBox.ItemHeight = 23;
            this.checkout_ListBox.Location = new System.Drawing.Point(12, 51);
            this.checkout_ListBox.Name = "checkout_ListBox";
            this.checkout_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkout_ListBox.Size = new System.Drawing.Size(283, 322);
            this.checkout_ListBox.TabIndex = 0;
            this.checkout_ListBox.SelectedIndexChanged += new System.EventHandler(this.checkout_ListBox_SelectedIndexChanged);
            // 
            // currCashInAcc
            // 
            this.currCashInAcc.AutoSize = true;
            this.currCashInAcc.BackColor = System.Drawing.Color.Transparent;
            this.currCashInAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currCashInAcc.Location = new System.Drawing.Point(13, 13);
            this.currCashInAcc.Name = "currCashInAcc";
            this.currCashInAcc.Size = new System.Drawing.Size(63, 24);
            this.currCashInAcc.TabIndex = 8;
            this.currCashInAcc.Text = "Cash :";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(82, 16);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(35, 22);
            this.balance.TabIndex = 9;
            this.balance.Text = "NA";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(220, 7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 31);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.currCashInAcc);
            this.Controls.Add(this.displayPrice);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.checkout_ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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