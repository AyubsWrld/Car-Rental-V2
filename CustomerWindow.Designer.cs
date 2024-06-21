namespace Cmpt291UI
{
    partial class CustomerWindow
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
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarColor = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CarEngine = new System.Windows.Forms.RichTextBox();
            this.CarYear = new System.Windows.Forms.RichTextBox();
            this.CarTrim = new System.Windows.Forms.RichTextBox();
            this.CarName = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rentalsBtn = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 75);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(91, 11);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(542, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome to Elites Car Rentals!";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(9, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(460, 557);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(208, 60);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Book Cars";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CarColor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CarEngine);
            this.panel2.Controls.Add(this.CarYear);
            this.panel2.Controls.Add(this.CarTrim);
            this.panel2.Controls.Add(this.CarName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 557);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 177);
            this.panel2.TabIndex = 7;
            // 
            // CarColor
            // 
            this.CarColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarColor.Font = new System.Drawing.Font("Calibri", 10F);
            this.CarColor.ForeColor = System.Drawing.Color.Black;
            this.CarColor.Location = new System.Drawing.Point(63, 135);
            this.CarColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarColor.Name = "CarColor";
            this.CarColor.Size = new System.Drawing.Size(164, 24);
            this.CarColor.TabIndex = 11;
            this.CarColor.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color:";
            // 
            // CarEngine
            // 
            this.CarEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarEngine.Font = new System.Drawing.Font("Calibri", 10F);
            this.CarEngine.ForeColor = System.Drawing.Color.Black;
            this.CarEngine.Location = new System.Drawing.Point(98, 102);
            this.CarEngine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarEngine.Name = "CarEngine";
            this.CarEngine.Size = new System.Drawing.Size(128, 24);
            this.CarEngine.TabIndex = 9;
            this.CarEngine.Text = "";
            // 
            // CarYear
            // 
            this.CarYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarYear.Font = new System.Drawing.Font("Calibri", 10F);
            this.CarYear.ForeColor = System.Drawing.Color.Black;
            this.CarYear.Location = new System.Drawing.Point(53, 72);
            this.CarYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarYear.Name = "CarYear";
            this.CarYear.Size = new System.Drawing.Size(84, 24);
            this.CarYear.TabIndex = 8;
            this.CarYear.Text = "";
            // 
            // CarTrim
            // 
            this.CarTrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarTrim.Font = new System.Drawing.Font("Calibri", 10F);
            this.CarTrim.ForeColor = System.Drawing.Color.Black;
            this.CarTrim.Location = new System.Drawing.Point(80, 40);
            this.CarTrim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarTrim.Name = "CarTrim";
            this.CarTrim.Size = new System.Drawing.Size(212, 24);
            this.CarTrim.TabIndex = 7;
            this.CarTrim.Text = "";
            // 
            // CarName
            // 
            this.CarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CarName.Font = new System.Drawing.Font("Calibri", 10F);
            this.CarName.ForeColor = System.Drawing.Color.Black;
            this.CarName.Location = new System.Drawing.Point(63, 8);
            this.CarName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(331, 24);
            this.CarName.TabIndex = 6;
            this.CarName.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Engine Type:";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(460, 704);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(208, 60);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(500, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Welcome,";
            // 
            // rentalsBtn
            // 
            this.rentalsBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rentalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rentalsBtn.Font = new System.Drawing.Font("Cambria", 12F);
            this.rentalsBtn.ForeColor = System.Drawing.Color.White;
            this.rentalsBtn.Location = new System.Drawing.Point(460, 631);
            this.rentalsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentalsBtn.Name = "rentalsBtn";
            this.rentalsBtn.Size = new System.Drawing.Size(208, 60);
            this.rentalsBtn.TabIndex = 6;
            this.rentalsBtn.Text = "My Rentals";
            this.rentalsBtn.UseVisualStyleBackColor = false;
            this.rentalsBtn.Click += new System.EventHandler(this.rentalsBtn_Click);
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserName.Font = new System.Drawing.Font("Calibri", 12F);
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.Location = new System.Drawing.Point(581, 98);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(96, 24);
            this.UserName.TabIndex = 10;
            this.UserName.Text = "";
            // 
            // CustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(712, 804);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.rentalsBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerWindow";
            this.Text = "CustomerWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox CarEngine;
        private System.Windows.Forms.RichTextBox CarYear;
        private System.Windows.Forms.RichTextBox CarTrim;
        private System.Windows.Forms.RichTextBox CarName;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox CarColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rentalsBtn;
        private System.Windows.Forms.RichTextBox UserName;
    }
}