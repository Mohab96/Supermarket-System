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
            this.prdctName = new System.Windows.Forms.Label();
            this.prdctPrice = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prdctPic = new System.Windows.Forms.PictureBox();
            this.lbldis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdctPic)).BeginInit();
            this.SuspendLayout();
            // 
            // prdctName
            // 
            this.prdctName.AutoSize = true;
            this.prdctName.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.prdctName.Location = new System.Drawing.Point(16, 176);
            this.prdctName.Name = "prdctName";
            this.prdctName.Size = new System.Drawing.Size(80, 33);
            this.prdctName.TabIndex = 1;
            this.prdctName.Text = "name";
            this.prdctName.Click += new System.EventHandler(this.prdctName_Click);
            // 
            // prdctPrice
            // 
            this.prdctPrice.AutoSize = true;
            this.prdctPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.prdctPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.prdctPrice.Location = new System.Drawing.Point(13, 217);
            this.prdctPrice.Name = "prdctPrice";
            this.prdctPrice.Size = new System.Drawing.Size(99, 44);
            this.prdctPrice.TabIndex = 2;
            this.prdctPrice.Text = "price";
            this.prdctPrice.Click += new System.EventHandler(this.prdctPrice_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd.Location = new System.Drawing.Point(19, 276);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(213, 89);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add to cart";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::supermarketSystem.Properties.Resources.offer3;
            this.pictureBox1.Location = new System.Drawing.Point(163, 185);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // prdctPic
            // 
            this.prdctPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prdctPic.BackColor = System.Drawing.Color.Transparent;
            this.prdctPic.Location = new System.Drawing.Point(19, 12);
            this.prdctPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prdctPic.Name = "prdctPic";
            this.prdctPic.Size = new System.Drawing.Size(211, 156);
            this.prdctPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prdctPic.TabIndex = 0;
            this.prdctPic.TabStop = false;
            // 
            // lbldis
            // 
            this.lbldis.AutoSize = true;
            this.lbldis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(48)))));
            this.lbldis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.lbldis.Location = new System.Drawing.Point(177, 194);
            this.lbldis.Name = "lbldis";
            this.lbldis.Size = new System.Drawing.Size(35, 18);
            this.lbldis.TabIndex = 6;
            this.lbldis.Text = "100";
            // 
            // itemForUserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 375);
            this.Controls.Add(this.lbldis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.prdctPrice);
            this.Controls.Add(this.prdctName);
            this.Controls.Add(this.prdctPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "itemForUserMainMenu";
            this.Text = "50";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdctPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox prdctPic;
        public System.Windows.Forms.Label prdctName;
        public System.Windows.Forms.Label prdctPrice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldis;
    }
}