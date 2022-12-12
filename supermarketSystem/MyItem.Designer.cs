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
            this.pbicon = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbicon
            // 
            this.pbicon.Location = new System.Drawing.Point(0, 0);
            this.pbicon.Name = "pbicon";
            this.pbicon.Size = new System.Drawing.Size(150, 127);
            this.pbicon.TabIndex = 0;
            this.pbicon.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(61, 134);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title";
            this.lbltitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(0, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(28, 13);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "0.00";
            // 
            // MyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbicon);
            this.Name = "MyItem";
            this.Load += new System.EventHandler(this.MyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbicon;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblprice;
    }
}
