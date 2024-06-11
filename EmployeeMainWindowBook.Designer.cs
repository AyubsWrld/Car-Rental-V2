namespace Cmpt291UI
{
    partial class EmployeeMainWindowBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bookEmployeeIDBox = new System.Windows.Forms.RichTextBox();
            this.ClearBottomButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SelectBottomButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bookCarVINBox = new System.Windows.Forms.RichTextBox();
            this.bookDateFromBox = new System.Windows.Forms.RichTextBox();
            this.bookDateToBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchDateToBox = new System.Windows.Forms.RichTextBox();
            this.searchDateFromBox = new System.Windows.Forms.RichTextBox();
            this.searchMonthlyCostBox = new System.Windows.Forms.RichTextBox();
            this.SearchWeeklyCostBox = new System.Windows.Forms.RichTextBox();
            this.searchDailyCostBox = new System.Windows.Forms.RichTextBox();
            this.searchCarYearBox = new System.Windows.Forms.RichTextBox();
            this.SearchCarTrimBox = new System.Windows.Forms.RichTextBox();
            this.SearchCarTypeBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBranchBox = new System.Windows.Forms.RichTextBox();
            this.SearchCarEngineBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.addToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2923, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(282, 54);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(282, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(162, 48);
            this.databaseToolStripMenuItem.Text = "Book Car";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(241, 54);
            this.carsToolStripMenuItem.Text = "Cars";
            this.carsToolStripMenuItem.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsToolStripMenuItem1,
            this.customersToolStripMenuItem1,
            this.employeesToolStripMenuItem1,
            this.rentalTransactionsToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 48);
            this.addToolStripMenuItem.Text = "Add/Remove";
            // 
            // carsToolStripMenuItem1
            // 
            this.carsToolStripMenuItem1.Name = "carsToolStripMenuItem1";
            this.carsToolStripMenuItem1.Size = new System.Drawing.Size(448, 54);
            this.carsToolStripMenuItem1.Text = "Cars";
            this.carsToolStripMenuItem1.Click += new System.EventHandler(this.carsToolStripMenuItem1_Click);
            // 
            // customersToolStripMenuItem1
            // 
            this.customersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem});
            this.customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            this.customersToolStripMenuItem1.Size = new System.Drawing.Size(448, 54);
            this.customersToolStripMenuItem1.Text = "Customers";
            this.customersToolStripMenuItem1.Click += new System.EventHandler(this.customersToolStripMenuItem1_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(428, 54);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(428, 54);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            this.removeCustomerToolStripMenuItem.Click += new System.EventHandler(this.removeCustomerToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem1
            // 
            this.employeesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem});
            this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(448, 54);
            this.employeesToolStripMenuItem1.Text = "Employees";
            this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem1_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            // 
            // rentalTransactionsToolStripMenuItem
            // 
            this.rentalTransactionsToolStripMenuItem.Name = "rentalTransactionsToolStripMenuItem";
            this.rentalTransactionsToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.rentalTransactionsToolStripMenuItem.Text = "Rental Transactions";
            this.rentalTransactionsToolStripMenuItem.Click += new System.EventHandler(this.rentalTransactionsToolStripMenuItem_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(144, 48);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(287, 54);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1032, 44);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2923, 1373);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1067F));
            this.tableLayoutPanel4.Controls.Add(this.bookEmployeeIDBox, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.ClearBottomButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.SelectBottomButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.bookCarVINBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.bookDateFromBox, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.bookDateToBox, 4, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 1226);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(2917, 134);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // bookEmployeeIDBox
            // 
            this.bookEmployeeIDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookEmployeeIDBox.Location = new System.Drawing.Point(653, 73);
            this.bookEmployeeIDBox.Name = "bookEmployeeIDBox";
            this.bookEmployeeIDBox.Size = new System.Drawing.Size(394, 64);
            this.bookEmployeeIDBox.TabIndex = 31;
            this.bookEmployeeIDBox.Text = "";
            // 
            // ClearBottomButton
            // 
            this.ClearBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearBottomButton.Location = new System.Drawing.Point(3, 73);
            this.ClearBottomButton.Name = "ClearBottomButton";
            this.ClearBottomButton.Size = new System.Drawing.Size(244, 64);
            this.ClearBottomButton.TabIndex = 28;
            this.ClearBottomButton.Text = "Clear";
            this.ClearBottomButton.UseVisualStyleBackColor = true;
            this.ClearBottomButton.Click += new System.EventHandler(this.ClearBottomButton_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(1453, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(394, 70);
            this.label15.TabIndex = 5;
            this.label15.Text = "Date-To-(DD/MM/YYYY)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(1053, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 70);
            this.label14.TabIndex = 4;
            this.label14.Text = "Date-From-(DD/MM/YYYY)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(653, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(394, 70);
            this.label12.TabIndex = 2;
            this.label12.Text = "EmployeeID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectBottomButton
            // 
            this.SelectBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectBottomButton.Location = new System.Drawing.Point(3, 3);
            this.SelectBottomButton.Name = "SelectBottomButton";
            this.SelectBottomButton.Size = new System.Drawing.Size(244, 64);
            this.SelectBottomButton.TabIndex = 0;
            this.SelectBottomButton.Text = "Book";
            this.SelectBottomButton.UseVisualStyleBackColor = true;
            this.SelectBottomButton.Click += new System.EventHandler(this.SelectBottomButton_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(253, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(394, 70);
            this.label11.TabIndex = 1;
            this.label11.Text = "Car VIN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookCarVINBox
            // 
            this.bookCarVINBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookCarVINBox.Location = new System.Drawing.Point(253, 73);
            this.bookCarVINBox.Name = "bookCarVINBox";
            this.bookCarVINBox.Size = new System.Drawing.Size(394, 64);
            this.bookCarVINBox.TabIndex = 29;
            this.bookCarVINBox.Text = "";
            // 
            // bookDateFromBox
            // 
            this.bookDateFromBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDateFromBox.Location = new System.Drawing.Point(1053, 73);
            this.bookDateFromBox.Name = "bookDateFromBox";
            this.bookDateFromBox.Size = new System.Drawing.Size(394, 64);
            this.bookDateFromBox.TabIndex = 30;
            this.bookDateFromBox.Text = "";
            // 
            // bookDateToBox
            // 
            this.bookDateToBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDateToBox.Location = new System.Drawing.Point(1453, 73);
            this.bookDateToBox.Name = "bookDateToBox";
            this.bookDateToBox.Size = new System.Drawing.Size(394, 64);
            this.bookDateToBox.TabIndex = 32;
            this.bookDateToBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 567F));
            this.tableLayoutPanel1.Controls.Add(this.searchDateToBox, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchDateFromBox, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchMonthlyCostBox, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchWeeklyCostBox, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchDailyCostBox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchCarYearBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchCarTrimBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchCarTypeBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchTopButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchBranchBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchCarEngineBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2917, 132);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // searchDateToBox
            // 
            this.searchDateToBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDateToBox.Location = new System.Drawing.Point(2353, 73);
            this.searchDateToBox.Name = "searchDateToBox";
            this.searchDateToBox.Size = new System.Drawing.Size(561, 64);
            this.searchDateToBox.TabIndex = 42;
            this.searchDateToBox.Text = "";
            // 
            // searchDateFromBox
            // 
            this.searchDateFromBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDateFromBox.Location = new System.Drawing.Point(1953, 73);
            this.searchDateFromBox.Name = "searchDateFromBox";
            this.searchDateFromBox.Size = new System.Drawing.Size(394, 64);
            this.searchDateFromBox.TabIndex = 41;
            this.searchDateFromBox.Text = "";
            // 
            // searchMonthlyCostBox
            // 
            this.searchMonthlyCostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMonthlyCostBox.Location = new System.Drawing.Point(1703, 73);
            this.searchMonthlyCostBox.Name = "searchMonthlyCostBox";
            this.searchMonthlyCostBox.Size = new System.Drawing.Size(244, 64);
            this.searchMonthlyCostBox.TabIndex = 40;
            this.searchMonthlyCostBox.Text = "";
            // 
            // SearchWeeklyCostBox
            // 
            this.SearchWeeklyCostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchWeeklyCostBox.Location = new System.Drawing.Point(1453, 73);
            this.SearchWeeklyCostBox.Name = "SearchWeeklyCostBox";
            this.SearchWeeklyCostBox.Size = new System.Drawing.Size(244, 64);
            this.SearchWeeklyCostBox.TabIndex = 39;
            this.SearchWeeklyCostBox.Text = "";
            // 
            // searchDailyCostBox
            // 
            this.searchDailyCostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDailyCostBox.Location = new System.Drawing.Point(1253, 73);
            this.searchDailyCostBox.Name = "searchDailyCostBox";
            this.searchDailyCostBox.Size = new System.Drawing.Size(194, 64);
            this.searchDailyCostBox.TabIndex = 38;
            this.searchDailyCostBox.Text = "";
            // 
            // searchCarYearBox
            // 
            this.searchCarYearBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCarYearBox.Location = new System.Drawing.Point(1053, 73);
            this.searchCarYearBox.Name = "searchCarYearBox";
            this.searchCarYearBox.Size = new System.Drawing.Size(194, 64);
            this.searchCarYearBox.TabIndex = 37;
            this.searchCarYearBox.Text = "";
            // 
            // SearchCarTrimBox
            // 
            this.SearchCarTrimBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchCarTrimBox.Location = new System.Drawing.Point(853, 73);
            this.SearchCarTrimBox.Name = "SearchCarTrimBox";
            this.SearchCarTrimBox.Size = new System.Drawing.Size(194, 64);
            this.SearchCarTrimBox.TabIndex = 36;
            this.SearchCarTrimBox.Text = "";
            // 
            // SearchCarTypeBox
            // 
            this.SearchCarTypeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchCarTypeBox.Location = new System.Drawing.Point(453, 73);
            this.SearchCarTypeBox.Name = "SearchCarTypeBox";
            this.SearchCarTypeBox.Size = new System.Drawing.Size(194, 64);
            this.SearchCarTypeBox.TabIndex = 35;
            this.SearchCarTypeBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2353, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(561, 70);
            this.label10.TabIndex = 31;
            this.label10.Text = "Date-To-(DD/MM/YYYY)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(1953, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(394, 70);
            this.label9.TabIndex = 30;
            this.label9.Text = "Date-From-(DD/MM/YYYY)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(1703, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 70);
            this.label8.TabIndex = 29;
            this.label8.Text = "Monthly Cost <=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(1253, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 70);
            this.label6.TabIndex = 18;
            this.label6.Text = "Daily Cost <=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(1053, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 70);
            this.label5.TabIndex = 17;
            this.label5.Text = "Car Year <=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(853, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 70);
            this.label4.TabIndex = 16;
            this.label4.Text = "Car Trim";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(653, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 70);
            this.label3.TabIndex = 15;
            this.label3.Text = "Car Engine";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(453, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 70);
            this.label2.TabIndex = 14;
            this.label2.Text = "Car Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTopButton
            // 
            this.SearchTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTopButton.Location = new System.Drawing.Point(3, 3);
            this.SearchTopButton.Name = "SearchTopButton";
            this.SearchTopButton.Size = new System.Drawing.Size(244, 64);
            this.SearchTopButton.TabIndex = 0;
            this.SearchTopButton.Text = "Search";
            this.SearchTopButton.UseVisualStyleBackColor = true;
            this.SearchTopButton.Click += new System.EventHandler(this.SearchTopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(253, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(1453, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 70);
            this.label7.TabIndex = 28;
            this.label7.Text = "Weekly Cost <=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBranchBox
            // 
            this.SearchBranchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBranchBox.Location = new System.Drawing.Point(253, 73);
            this.SearchBranchBox.Name = "SearchBranchBox";
            this.SearchBranchBox.Size = new System.Drawing.Size(194, 64);
            this.SearchBranchBox.TabIndex = 32;
            this.SearchBranchBox.Text = "";
            // 
            // SearchCarEngineBox
            // 
            this.SearchCarEngineBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchCarEngineBox.Location = new System.Drawing.Point(653, 73);
            this.SearchCarEngineBox.Name = "SearchCarEngineBox";
            this.SearchCarEngineBox.Size = new System.Drawing.Size(194, 64);
            this.SearchCarEngineBox.TabIndex = 33;
            this.SearchCarEngineBox.Text = "";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 64);
            this.button1.TabIndex = 43;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(2917, 1077);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // EmployeeMainWindowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2923, 1422);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeMainWindowBook";
            this.Text = "Employee Window";
            this.Load += new System.EventHandler(this.EmployeeWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox searchDateToBox;
        private System.Windows.Forms.RichTextBox searchDateFromBox;
        private System.Windows.Forms.RichTextBox searchMonthlyCostBox;
        private System.Windows.Forms.RichTextBox SearchWeeklyCostBox;
        private System.Windows.Forms.RichTextBox searchDailyCostBox;
        private System.Windows.Forms.RichTextBox searchCarYearBox;
        private System.Windows.Forms.RichTextBox SearchCarTrimBox;
        private System.Windows.Forms.RichTextBox SearchCarTypeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchTopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox SearchBranchBox;
        private System.Windows.Forms.RichTextBox SearchCarEngineBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox bookEmployeeIDBox;
        private System.Windows.Forms.Button ClearBottomButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SelectBottomButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox bookCarVINBox;
        private System.Windows.Forms.RichTextBox bookDateFromBox;
        private System.Windows.Forms.RichTextBox bookDateToBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem rentalTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
    }
}