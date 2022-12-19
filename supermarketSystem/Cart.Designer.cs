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
            this.currCashInAcc = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.cartView = new System.Windows.Forms.DataGridView();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPrice
            // 
            this.displayPrice.AutoSize = true;
            this.displayPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrice.ForeColor = System.Drawing.Color.Green;
            this.displayPrice.Location = new System.Drawing.Point(141, 412);
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
            this.totalPriceLbl.Location = new System.Drawing.Point(26, 412);
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
            this.checkoutBtn.Location = new System.Drawing.Point(305, 441);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(129, 40);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
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
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(82, 13);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(40, 25);
            this.balance.TabIndex = 9;
            this.balance.Text = "NA";
            // 
            // cartView
            // 
            this.cartView.AllowUserToAddRows = false;
            this.cartView.AllowUserToDeleteRows = false;
            this.cartView.BackgroundColor = System.Drawing.Color.White;
            this.cartView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proID,
            this.proName,
            this.proQuantity,
            this.proPrice});
            this.cartView.GridColor = System.Drawing.SystemColors.Desktop;
            this.cartView.Location = new System.Drawing.Point(46, 49);
            this.cartView.Name = "cartView";
            this.cartView.Size = new System.Drawing.Size(645, 360);
            this.cartView.TabIndex = 11;
            this.cartView.DoubleClick += new System.EventHandler(this.cartView_DoubleClick);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabel.Location = new System.Drawing.Point(417, 19);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(298, 18);
            this.DeleteLabel.TabIndex = 12;
            this.DeleteLabel.Text = "Double Click to remove a product from the cart";
            // 
            // proID
            // 
            this.proID.HeaderText = "ID";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            // 
            // proName
            // 
            this.proName.HeaderText = "Name";
            this.proName.Name = "proName";
            this.proName.ReadOnly = true;
            this.proName.Width = 300;
            // 
            // proQuantity
            // 
            this.proQuantity.HeaderText = "Quantity";
            this.proQuantity.Name = "proQuantity";
            this.proQuantity.ReadOnly = true;
            // 
            // proPrice
            // 
            this.proPrice.HeaderText = "Total Price";
            this.proPrice.Name = "proPrice";
            this.proPrice.ReadOnly = true;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 495);
            this.Controls.Add(this.DeleteLabel);
            this.Controls.Add(this.cartView);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.currCashInAcc);
            this.Controls.Add(this.displayPrice);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label displayPrice;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Label currCashInAcc;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.DataGridView cartView;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrice;
    }
}