namespace supermarketSystem
{
    partial class itemForUserMainMenu
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
            this.prdctPic = new System.Windows.Forms.PictureBox();
            this.prdctName = new System.Windows.Forms.Label();
            this.prdctPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prdctPic)).BeginInit();
            this.SuspendLayout();
            // 
            // prdctPic
            // 
            this.prdctPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prdctPic.BackColor = System.Drawing.Color.SteelBlue;
            this.prdctPic.Location = new System.Drawing.Point(127, 11);
            this.prdctPic.Name = "prdctPic";
            this.prdctPic.Size = new System.Drawing.Size(68, 72);
            this.prdctPic.TabIndex = 0;
            this.prdctPic.TabStop = false;
            // 
            // prdctName
            // 
            this.prdctName.AutoSize = true;
            this.prdctName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctName.Location = new System.Drawing.Point(16, 20);
            this.prdctName.Name = "prdctName";
            this.prdctName.Size = new System.Drawing.Size(38, 16);
            this.prdctName.TabIndex = 1;
            this.prdctName.Text = "name";
            // 
            // prdctPrice
            // 
            this.prdctPrice.AutoSize = true;
            this.prdctPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctPrice.Location = new System.Drawing.Point(19, 68);
            this.prdctPrice.Name = "prdctPrice";
            this.prdctPrice.Size = new System.Drawing.Size(36, 16);
            this.prdctPrice.TabIndex = 2;
            this.prdctPrice.Text = "price";
            // 
            // itemForUserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(205, 100);
            this.Controls.Add(this.prdctPrice);
            this.Controls.Add(this.prdctName);
            this.Controls.Add(this.prdctPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "itemForUserMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.prdctPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox prdctPic;
        public System.Windows.Forms.Label prdctName;
        public System.Windows.Forms.Label prdctPrice;
    }
}