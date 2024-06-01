namespace Cmpt291UI
{
    partial class RentalQuery
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.CarTypeToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.RentalTransactionToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.results = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.results, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.Search, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 720F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(2726, 1473);
            this.TableLayoutPanel1.TabIndex = 0;
            this.TableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2726, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarsToolBox,
            this.CarTypeToolBox,
            this.CustomerToolBox,
            this.EmployeesToolBox,
            this.RentalTransactionToolBox});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(165, 48);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // CarsToolBox
            // 
            this.CarsToolBox.Name = "CarsToolBox";
            this.CarsToolBox.Size = new System.Drawing.Size(448, 54);
            this.CarsToolBox.Text = "Cars";
            this.CarsToolBox.Click += new System.EventHandler(this.CarToolBox);
            // 
            // CarTypeToolBox
            // 
            this.CarTypeToolBox.Name = "CarTypeToolBox";
            this.CarTypeToolBox.Size = new System.Drawing.Size(448, 54);
            this.CarTypeToolBox.Text = "Car Types";
            this.CarTypeToolBox.Click += new System.EventHandler(this.CarTypeToolBox_Click);
            // 
            // CustomerToolBox
            // 
            this.CustomerToolBox.Name = "CustomerToolBox";
            this.CustomerToolBox.Size = new System.Drawing.Size(448, 54);
            this.CustomerToolBox.Text = "Customers";
            this.CustomerToolBox.Click += new System.EventHandler(this.CustomerToolBox_Click);
            // 
            // EmployeesToolBox
            // 
            this.EmployeesToolBox.Name = "EmployeesToolBox";
            this.EmployeesToolBox.Size = new System.Drawing.Size(448, 54);
            this.EmployeesToolBox.Text = "Employees";
            this.EmployeesToolBox.Click += new System.EventHandler(this.EmployeesToolBox_Click);
            // 
            // RentalTransactionToolBox
            // 
            this.RentalTransactionToolBox.Name = "RentalTransactionToolBox";
            this.RentalTransactionToolBox.Size = new System.Drawing.Size(448, 54);
            this.RentalTransactionToolBox.Text = "Rental Transactions";
            this.RentalTransactionToolBox.Click += new System.EventHandler(this.RentalTransactionToolBox_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runQueryToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(123, 48);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // runQueryToolStripMenuItem
            // 
            this.runQueryToolStripMenuItem.Name = "runQueryToolStripMenuItem";
            this.runQueryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runQueryToolStripMenuItem.Size = new System.Drawing.Size(374, 54);
            this.runQueryToolStripMenuItem.Text = "Run Query";
            this.runQueryToolStripMenuItem.Click += new System.EventHandler(this.runQueryToolStripMenuItem_Click);
            // 
            // results
            // 
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(3, 148);
            this.results.Name = "results";
            this.results.RowHeadersWidth = 102;
            this.results.RowTemplate.Height = 40;
            this.results.Size = new System.Drawing.Size(2720, 714);
            this.results.TabIndex = 1;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCarInfo);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(3, 78);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(311, 64);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SearchButton);
            // 
            // RentalQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2726, 1473);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "RentalQuery";
            this.Text = "Car Query";
            this.Load += new System.EventHandler(this.RentalQuery_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsToolBox;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolBox;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarTypeToolBox;
        private System.Windows.Forms.ToolStripMenuItem EmployeesToolBox;
        private System.Windows.Forms.ToolStripMenuItem RentalTransactionToolBox;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Button Search;
    }
}

