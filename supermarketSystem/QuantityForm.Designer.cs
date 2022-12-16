namespace supermarketSystem
{
    partial class QuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityForm));
            this.button1 = new System.Windows.Forms.Button();
            this.lbloff = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblfinalprice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtqty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(129, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloff
            // 
            this.lbloff.AutoSize = true;
            this.lbloff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.lbloff.Location = new System.Drawing.Point(126, 29);
            this.lbloff.Name = "lbloff";
            this.lbloff.Size = new System.Drawing.Size(74, 18);
            this.lbloff.TabIndex = 2;
            this.lbloff.Text = "0 % OFF";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Silver;
            this.lblprice.Location = new System.Drawing.Point(24, 29);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(54, 18);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "$ 0.00";
            // 
            // lblfinalprice
            // 
            this.lblfinalprice.AutoSize = true;
            this.lblfinalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lblfinalprice.Location = new System.Drawing.Point(24, 52);
            this.lblfinalprice.Name = "lblfinalprice";
            this.lblfinalprice.Size = new System.Drawing.Size(66, 22);
            this.lblfinalprice.TabIndex = 4;
            this.lblfinalprice.Text = "$ 0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtqty
            // 
            this.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtqty.Location = new System.Drawing.Point(27, 84);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(51, 24);
            this.txtqty.TabIndex = 7;
            this.txtqty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtqty.ValueChanged += new System.EventHandler(this.txtqty_ValueChanged);
            // 
            // QuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(231, 138);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfinalprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbloff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtqty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuantityForm";
            this.Load += new System.EventHandler(this.QuantityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbloff;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblfinalprice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown txtqty;
    }
}