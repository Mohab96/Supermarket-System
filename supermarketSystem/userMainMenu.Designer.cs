namespace supermarketSystem
{
    partial class userMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.goToPayForm = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.productsMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.goToPayForm);
            this.panel1.Controls.Add(this.money);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.cash);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 91);
            this.panel1.TabIndex = 0;
            // 
            // goToPayForm
            // 
            this.goToPayForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToPayForm.Location = new System.Drawing.Point(465, 17);
            this.goToPayForm.Name = "goToPayForm";
            this.goToPayForm.Size = new System.Drawing.Size(168, 57);
            this.goToPayForm.TabIndex = 4;
            this.goToPayForm.Text = "Proceed to checkout";
            this.goToPayForm.UseVisualStyleBackColor = true;
            this.goToPayForm.Click += new System.EventHandler(this.goToPayForm_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.money.Location = new System.Drawing.Point(60, 55);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(49, 19);
            this.money.TabIndex = 3;
            this.money.Text = "money";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.name.Location = new System.Drawing.Point(97, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 19);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cash.Location = new System.Drawing.Point(21, 55);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(47, 19);
            this.cash.TabIndex = 1;
            this.cash.Text = "Cash: ";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(12, 18);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(84, 21);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome,";
            // 
            // productsMenu
            // 
            this.productsMenu.AutoScroll = true;
            this.productsMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsMenu.Location = new System.Drawing.Point(9, 104);
            this.productsMenu.Name = "productsMenu";
            this.productsMenu.Size = new System.Drawing.Size(652, 334);
            this.productsMenu.TabIndex = 1;
            // 
            // userMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.productsMenu);
            this.Controls.Add(this.panel1);
            this.Name = "userMainMenu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.userMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button goToPayForm;
        private System.Windows.Forms.FlowLayoutPanel productsMenu;
    }
}