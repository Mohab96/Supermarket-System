namespace supermarketSystem
{
    partial class Form1
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
            this.Loginbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.passwod = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.isShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.Loginbutton.Location = new System.Drawing.Point(1, 4);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(223, 49);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(232, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Signup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(21, 137);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(86, 29);
            this.email.TabIndex = 2;
            this.email.Text = "Email :";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(168, 138);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(260, 26);
            this.EmailTextbox.TabIndex = 3;
            // 
            // passwod
            // 
            this.passwod.AutoSize = true;
            this.passwod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwod.Location = new System.Drawing.Point(21, 233);
            this.passwod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwod.Name = "passwod";
            this.passwod.Size = new System.Drawing.Size(132, 29);
            this.passwod.TabIndex = 4;
            this.passwod.Text = "Password :";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(165, 236);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(261, 28);
            this.PasswordTextbox.TabIndex = 5;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EnterButton.Location = new System.Drawing.Point(137, 361);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(163, 43);
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // isShow
            // 
            this.isShow.AutoSize = true;
            this.isShow.Location = new System.Drawing.Point(165, 272);
            this.isShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isShow.Name = "isShow";
            this.isShow.Size = new System.Drawing.Size(125, 21);
            this.isShow.TabIndex = 7;
            this.isShow.Text = "ShowPassword";
            this.isShow.UseVisualStyleBackColor = true;
            this.isShow.CheckedChanged += new System.EventHandler(this.isShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(445, 444);
            this.Controls.Add(this.isShow);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.passwod);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Loginbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label passwod;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.CheckBox isShow;
    }
}

