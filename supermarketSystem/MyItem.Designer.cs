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
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.ForeColor = System.Drawing.Color.Green;
            this.lblprice.Location = new System.Drawing.Point(10, 9);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(28, 13);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "0.00";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(212, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title";
            this.lbltitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbicon
            // 
            this.pbicon.Location = new System.Drawing.Point(13, 9);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(150, 127);
            this.pbicon.TabIndex = 0;
            this.pbicon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "buy product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbicon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MyItem";
            this.Size = new System.Drawing.Size(306, 150);
            this.Load += new System.EventHandler(this.MyItem_Load);
            this.MouseEnter += new System.EventHandler(this.MyItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
