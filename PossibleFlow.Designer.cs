namespace Cmpt291UI
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerLogIn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EmployeeLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cmpt291UI.Properties.Resources.Elite;
            this.pictureBox1.Location = new System.Drawing.Point(281, -65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerLogIn
            // 
            this.CustomerLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomerLogIn.Location = new System.Drawing.Point(395, 305);
            this.CustomerLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerLogIn.Name = "CustomerLogIn";
            this.CustomerLogIn.Size = new System.Drawing.Size(267, 62);
            this.CustomerLogIn.TabIndex = 1;
            this.CustomerLogIn.Text = "Customer Login";
            this.CustomerLogIn.UseVisualStyleBackColor = true;
            this.CustomerLogIn.Click += new System.EventHandler(this.CustomerLogIn_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(395, 479);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(267, 62);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Quit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmployeeLogIn
            // 
            this.EmployeeLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeLogIn.Location = new System.Drawing.Point(395, 395);
            this.EmployeeLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeLogIn.Name = "EmployeeLogIn";
            this.EmployeeLogIn.Size = new System.Drawing.Size(267, 62);
            this.EmployeeLogIn.TabIndex = 3;
            this.EmployeeLogIn.Text = "Employee Login";
            this.EmployeeLogIn.UseVisualStyleBackColor = true;
            this.EmployeeLogIn.Click += new System.EventHandler(this.EmployeeLogIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.EmployeeLogIn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CustomerLogIn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Possible_Flow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CustomerLogIn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EmployeeLogIn;
    }
}