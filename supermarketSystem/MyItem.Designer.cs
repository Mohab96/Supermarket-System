namespace supermarketSystem
{
    partial class MyItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblprice = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.pbicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Green;
            this.lblprice.Location = new System.Drawing.Point(99, 146);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(72, 25);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "0.00 $";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(10, 146);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(68, 26);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Name";
            this.lbltitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Teal;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Location = new System.Drawing.Point(15, 184);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 44);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            this.btnedit.MouseEnter += new System.EventHandler(this.btnedit_MouseEnter);
            this.btnedit.MouseLeave += new System.EventHandler(this.btnedit_MouseLeave);
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnbuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.ForeColor = System.Drawing.Color.Ivory;
            this.btnbuy.Location = new System.Drawing.Point(96, 184);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(75, 44);
            this.btnbuy.TabIndex = 4;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = false;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            this.btnbuy.MouseEnter += new System.EventHandler(this.btnbuy_MouseEnter);
            this.btnbuy.MouseLeave += new System.EventHandler(this.btnbuy_MouseLeave);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Ivory;
            this.btndel.Location = new System.Drawing.Point(15, 234);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(156, 44);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            this.btndel.MouseEnter += new System.EventHandler(this.btndel_MouseEnter);
            this.btndel.MouseLeave += new System.EventHandler(this.btndel_MouseLeave);
            // 
            // pbicon
            // 
            this.pbicon.Location = new System.Drawing.Point(13, 9);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(158, 127);
            this.pbicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbicon.TabIndex = 0;
            this.pbicon.TabStop = false;
            this.pbicon.Click += new System.EventHandler(this.pbicon_Click);
            // 
            // MyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbicon);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MyItem";
            this.Size = new System.Drawing.Size(183, 290);
            this.Load += new System.EventHandler(this.MyItem_Load);
            this.MouseEnter += new System.EventHandler(this.MyItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Button btndel;
    }
}
