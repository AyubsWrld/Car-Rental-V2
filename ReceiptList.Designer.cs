namespace Cmpt291UI
{
    partial class ReceiptList
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
            this.Header1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewReciept = new System.Windows.Forms.Button();
            this.returnOpt = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header1
            // 
            this.Header1.BackColor = System.Drawing.SystemColors.Control;
            this.Header1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header1.Location = new System.Drawing.Point(12, 12);
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(152, 39);
            this.Header1.TabIndex = 3;
            this.Header1.Text = "My Rentals";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(564, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewReciept
            // 
            this.viewReciept.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.viewReciept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewReciept.Font = new System.Drawing.Font("Cambria", 12F);
            this.viewReciept.ForeColor = System.Drawing.Color.White;
            this.viewReciept.Location = new System.Drawing.Point(195, 543);
            this.viewReciept.Name = "viewReciept";
            this.viewReciept.Size = new System.Drawing.Size(200, 50);
            this.viewReciept.TabIndex = 7;
            this.viewReciept.Text = "View Transaction Details";
            this.viewReciept.UseVisualStyleBackColor = false;
            this.viewReciept.Click += new System.EventHandler(this.viewReciept_Click);
            // 
            // returnOpt
            // 
            this.returnOpt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.returnOpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnOpt.Font = new System.Drawing.Font("Cambria", 12F);
            this.returnOpt.ForeColor = System.Drawing.Color.White;
            this.returnOpt.Location = new System.Drawing.Point(195, 487);
            this.returnOpt.Name = "returnOpt";
            this.returnOpt.Size = new System.Drawing.Size(200, 50);
            this.returnOpt.TabIndex = 8;
            this.returnOpt.Text = "Return";
            this.returnOpt.UseVisualStyleBackColor = false;
            this.returnOpt.Click += new System.EventHandler(this.returnOpt_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Cambria", 12F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(195, 599);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(200, 50);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ReceiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 654);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.returnOpt);
            this.Controls.Add(this.viewReciept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Header1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ReceiptList";
            this.Text = "ReceiptList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Header1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewReciept;
        private System.Windows.Forms.Button returnOpt;
        private System.Windows.Forms.Button closeBtn;
    }
}
