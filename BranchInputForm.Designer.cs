namespace Cmpt291UI
{
    partial class BranchInputForm
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
            this.Textbox = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textbox
            // 
            this.Textbox.AutoSize = true;
            this.Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Textbox.Location = new System.Drawing.Point(48, 38);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(113, 20);
=======
            this.Textbox.Location = new System.Drawing.Point(64, 47);
            this.Textbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(136, 25);
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
            this.Textbox.TabIndex = 0;
            this.Textbox.Text = "Return Branch";
            this.Textbox.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputBox
            // 
<<<<<<< HEAD
            this.inputBox.Location = new System.Drawing.Point(242, 38);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(58, 20);
=======
            this.inputBox.Location = new System.Drawing.Point(323, 47);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(76, 24);
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmBtn.Font = new System.Drawing.Font("Cambria", 12F);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.ConfirmBtn.Location = new System.Drawing.Point(51, 96);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(110, 52);
=======
            this.ConfirmBtn.Location = new System.Drawing.Point(68, 118);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(147, 64);
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "Confirm Return";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Cambria", 12F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.CancelBtn.Location = new System.Drawing.Point(190, 96);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(110, 52);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BranchInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 170);
=======
            this.CancelBtn.Location = new System.Drawing.Point(253, 118);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(147, 64);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // BranchInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 209);
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.Textbox);
<<<<<<< HEAD
=======
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
            this.Name = "BranchInputForm";
            this.Text = "BranchInputForm";
            this.Load += new System.EventHandler(this.BranchInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textbox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}