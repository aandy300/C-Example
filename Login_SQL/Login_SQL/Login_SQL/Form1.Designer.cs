
namespace Login_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.Account_text = new System.Windows.Forms.Label();
            this.Password_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(35, 141);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(75, 23);
            this.Enter_button.TabIndex = 0;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(133, 141);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(108, 33);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(100, 23);
            this.textBox_Account.TabIndex = 2;
            this.textBox_Account.TextChanged += new System.EventHandler(this.textBox1_Account_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(108, 79);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 23);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // Account_text
            // 
            this.Account_text.AutoSize = true;
            this.Account_text.Location = new System.Drawing.Point(35, 36);
            this.Account_text.Name = "Account_text";
            this.Account_text.Size = new System.Drawing.Size(53, 15);
            this.Account_text.TabIndex = 4;
            this.Account_text.Text = "Account";
            this.Account_text.Click += new System.EventHandler(this.Account_text1);
            // 
            // Password_text
            // 
            this.Password_text.AutoSize = true;
            this.Password_text.Location = new System.Drawing.Point(35, 87);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(60, 15);
            this.Password_text.TabIndex = 5;
            this.Password_text.Text = "Password";
            this.Password_text.Click += new System.EventHandler(this.Password_text2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 201);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Account_text);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Enter_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label Account_text;
        private System.Windows.Forms.Label Password_text;
    }
}

