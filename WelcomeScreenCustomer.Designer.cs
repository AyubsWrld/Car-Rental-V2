namespace Cmpt291UI
{
    partial class WelcomeScreenCustomer
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
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.CustomerNumBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.employeeNumLabel = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignUp.Font = new System.Drawing.Font("Cambria", 12F);
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.Location = new System.Drawing.Point(128, 277);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(207, 36);
            this.BtnSignUp.TabIndex = 17;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Cambria", 12F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(323, 335);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 31);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Cambria", 12F);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(243, 230);
            this.Login.Margin = new System.Windows.Forms.Padding(1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(92, 36);
            this.Login.TabIndex = 15;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Cambria", 12F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(128, 230);
            this.Clear.Margin = new System.Windows.Forms.Padding(1);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 36);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;

            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(191, 170);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(1);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(163, 22);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.UseSystemPasswordChar = true;

            // 
            // CustomerNumBox
            // 
            this.CustomerNumBox.Location = new System.Drawing.Point(191, 112);
            this.CustomerNumBox.Margin = new System.Windows.Forms.Padding(1);
            this.CustomerNumBox.Name = "CustomerNumBox";
            this.CustomerNumBox.Size = new System.Drawing.Size(163, 22);
            this.CustomerNumBox.TabIndex = 12;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(72, 172);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            // 
            // employeeNumLabel
            // 
            this.employeeNumLabel.AutoSize = true;
            this.employeeNumLabel.Location = new System.Drawing.Point(72, 116);
            this.employeeNumLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.employeeNumLabel.Name = "employeeNumLabel";
            this.employeeNumLabel.Size = new System.Drawing.Size(80, 16);
            this.employeeNumLabel.TabIndex = 10;
            this.employeeNumLabel.Text = "Customer ID";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Welcome.Font = new System.Drawing.Font("Arial", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(148, 19);
            this.Welcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(135, 32);
            this.Welcome.TabIndex = 9;
            this.Welcome.Text = "Welcome";
            // 
            // WelcomeScreenCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(451, 405);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.CustomerNumBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.employeeNumLabel);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomeScreenCustomer";
            this.Text = "WelcomeScreenCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox CustomerNumBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label employeeNumLabel;
        private System.Windows.Forms.Label Welcome;
    }
}