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
            this.btncash = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.btnsign = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btncash);
            this.panel1.Controls.Add(this.btnabout);
            this.panel1.Controls.Add(this.btnsign);
            this.panel1.Controls.Add(this.goToPayForm);
            this.panel1.Controls.Add(this.money);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.cash);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 112);
            this.panel1.TabIndex = 0;
            // 
            // btncash
            // 
            this.btncash.BackColor = System.Drawing.Color.Green;
            this.btncash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncash.ForeColor = System.Drawing.Color.White;
            this.btncash.Location = new System.Drawing.Point(664, 5);
            this.btncash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(243, 100);
            this.btncash.TabIndex = 5;
            this.btncash.Text = "Cash transaction";
            this.btncash.UseVisualStyleBackColor = false;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.btnabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.White;
            this.btnabout.Location = new System.Drawing.Point(915, 54);
            this.btnabout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(124, 48);
            this.btnabout.TabIndex = 4;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.Crimson;
            this.btnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.ForeColor = System.Drawing.Color.White;
            this.btnsign.Location = new System.Drawing.Point(915, 4);
            this.btnsign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(124, 48);
            this.btnsign.TabIndex = 3;
            this.btnsign.Text = "Sign out";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // goToPayForm
            // 
            this.goToPayForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.goToPayForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToPayForm.ForeColor = System.Drawing.Color.White;
            this.goToPayForm.Location = new System.Drawing.Point(1045, 4);
            this.goToPayForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goToPayForm.Name = "goToPayForm";
            this.goToPayForm.Size = new System.Drawing.Size(243, 100);
            this.goToPayForm.TabIndex = 4;
            this.goToPayForm.Text = "Proceed to checkout";
            this.goToPayForm.UseVisualStyleBackColor = false;
            this.goToPayForm.Click += new System.EventHandler(this.goToPayForm_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Green;
            this.money.Location = new System.Drawing.Point(166, 58);
            this.money.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(89, 37);
            this.money.TabIndex = 3;
            this.money.Text = "money";
            this.money.Click += new System.EventHandler(this.money_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name.Location = new System.Drawing.Point(195, 16);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(91, 36);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cash.Location = new System.Drawing.Point(45, 57);
            this.cash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(106, 36);
            this.cash.TabIndex = 1;
            this.cash.Text = "Cash: ";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.welcome.Location = new System.Drawing.Point(33, 14);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(154, 36);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome,";
            // 
            // productsMenu
            // 
            this.productsMenu.AutoScroll = true;
            this.productsMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productsMenu.Location = new System.Drawing.Point(12, 128);
            this.productsMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsMenu.Name = "productsMenu";
            this.productsMenu.Size = new System.Drawing.Size(1297, 555);
            this.productsMenu.TabIndex = 1;
            this.productsMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.productsMenu_Paint);
            // 
            // userMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 692);
            this.Controls.Add(this.productsMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "userMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userMainMenu_FormClosing);
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
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btncash;
    }
}