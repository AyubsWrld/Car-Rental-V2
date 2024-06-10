namespace Cmpt291UI
{
    partial class LoginScreen
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
            this.Welcome = new System.Windows.Forms.Label();
            this.employeeNumLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.employeeNumBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Welcome.Font = new System.Drawing.Font("Arial", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(168, 38);
            this.Welcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(135, 32);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // employeeNumLabel
            // 
            this.employeeNumLabel.AutoSize = true;
            this.employeeNumLabel.Location = new System.Drawing.Point(73, 116);
            this.employeeNumLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.employeeNumLabel.Name = "employeeNumLabel";
            this.employeeNumLabel.Size = new System.Drawing.Size(85, 16);
            this.employeeNumLabel.TabIndex = 1;
            this.employeeNumLabel.Text = "Employee ID";
            this.employeeNumLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(73, 172);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // employeeNumBox
            // 
            this.employeeNumBox.Location = new System.Drawing.Point(192, 112);
            this.employeeNumBox.Margin = new System.Windows.Forms.Padding(1);
            this.employeeNumBox.Name = "employeeNumBox";
            this.employeeNumBox.Size = new System.Drawing.Size(163, 22);
            this.employeeNumBox.TabIndex = 3;
            this.employeeNumBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(192, 170);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(1);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(163, 22);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(129, 230);
            this.Clear.Margin = new System.Windows.Forms.Padding(1);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 36);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(244, 230);
            this.Login.Margin = new System.Windows.Forms.Padding(1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(92, 36);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(324, 335);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 31);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(129, 277);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(207, 36);
            this.BtnSignUp.TabIndex = 8;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 405);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.employeeNumBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.employeeNumLabel);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label employeeNumLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox employeeNumBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BtnSignUp;
    }
}