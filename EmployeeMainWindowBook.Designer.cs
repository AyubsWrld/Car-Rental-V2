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
        /// 
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
            this.carTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeID = new System.Windows.Forms.RichTextBox();
            this.ClearBottomButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SelectBottomButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CarVIN = new System.Windows.Forms.RichTextBox();
            this.DateFromBottom = new System.Windows.Forms.RichTextBox();
            this.DateToBottom = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateToTop = new System.Windows.Forms.RichTextBox();
            this.DateFromTop = new System.Windows.Forms.RichTextBox();
            this.MonthlyCost = new System.Windows.Forms.RichTextBox();
            this.WeeklyCost = new System.Windows.Forms.RichTextBox();
            this.DailyCost = new System.Windows.Forms.RichTextBox();
            this.CarYear = new System.Windows.Forms.RichTextBox();
            this.CarTrim = new System.Windows.Forms.RichTextBox();
            this.CarType = new System.Windows.Forms.RichTextBox();
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
            this.BranchNum = new System.Windows.Forms.RichTextBox();
            this.CarEngine = new System.Windows.Forms.RichTextBox();
            this.ClearTopButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.addToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsToolStripMenuItem,
            this.carTypesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.rentalTransactionsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.carsToolStripMenuItem.Text = "Cars";
            this.carsToolStripMenuItem.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
            // 
            // carTypesToolStripMenuItem
            // 
            this.carTypesToolStripMenuItem.Name = "carTypesToolStripMenuItem";
            this.carTypesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.carTypesToolStripMenuItem.Text = "Car Types";
            this.carTypesToolStripMenuItem.Click += new System.EventHandler(this.carTypesToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // rentalTransactionsToolStripMenuItem
            // 
            this.rentalTransactionsToolStripMenuItem.Name = "rentalTransactionsToolStripMenuItem";
            this.rentalTransactionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rentalTransactionsToolStripMenuItem.Text = "Rental Transactions";
            this.rentalTransactionsToolStripMenuItem.Click += new System.EventHandler(this.rentalTransactionsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsToolStripMenuItem1,
            this.employeesToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.addToolStripMenuItem.Text = "Add/Delete";
            // 
            // carsToolStripMenuItem1
            // 
            this.carsToolStripMenuItem1.Name = "carsToolStripMenuItem1";
            this.carsToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.carsToolStripMenuItem1.Text = "Cars";
            this.carsToolStripMenuItem1.Click += new System.EventHandler(this.carsToolStripMenuItem1_Click);
            // 
            // employeesToolStripMenuItem1
            // 
            this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem1.Text = "Employees";
            this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(387, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(3, 3);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1096, 572);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel4.Controls.Add(this.EmployeeID, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.ClearBottomButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.SelectBottomButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.CarVIN, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.DateFromBottom, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.DateToBottom, 4, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 517);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1094, 57);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeID.Location = new System.Drawing.Point(245, 30);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(1);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(148, 27);
            this.EmployeeID.TabIndex = 31;
            this.EmployeeID.Text = "";
            // 
            // ClearBottomButton
            // 
            this.ClearBottomButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClearBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearBottomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBottomButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.ClearBottomButton.ForeColor = System.Drawing.Color.White;
            this.ClearBottomButton.Location = new System.Drawing.Point(1, 30);
            this.ClearBottomButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearBottomButton.Name = "ClearBottomButton";
            this.ClearBottomButton.Size = new System.Drawing.Size(92, 27);
            this.ClearBottomButton.TabIndex = 28;
            this.ClearBottomButton.Text = "Clear";
            this.ClearBottomButton.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(545, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 29);
            this.label15.TabIndex = 5;
            this.label15.Text = "Date-To-(DD/MM/YYYY)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(395, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 29);
            this.label14.TabIndex = 4;
            this.label14.Text = "Date-From-(DD/MM/YYYY)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(245, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "EmployeeID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectBottomButton
            // 
            this.SelectBottomButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SelectBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectBottomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectBottomButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.SelectBottomButton.ForeColor = System.Drawing.Color.White;
            this.SelectBottomButton.Location = new System.Drawing.Point(1, 1);
            this.SelectBottomButton.Margin = new System.Windows.Forms.Padding(1);
            this.SelectBottomButton.Name = "SelectBottomButton";
            this.SelectBottomButton.Size = new System.Drawing.Size(92, 27);
            this.SelectBottomButton.TabIndex = 0;
            this.SelectBottomButton.Text = "Book";
            this.SelectBottomButton.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(95, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Car VIN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarVIN
            // 
            this.CarVIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarVIN.Location = new System.Drawing.Point(95, 30);
            this.CarVIN.Margin = new System.Windows.Forms.Padding(1);
            this.CarVIN.Name = "CarVIN";
            this.CarVIN.Size = new System.Drawing.Size(148, 27);
            this.CarVIN.TabIndex = 29;
            this.CarVIN.Text = "";
            // 
            // DateFromBottom
            // 
            this.DateFromBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateFromBottom.Location = new System.Drawing.Point(395, 30);
            this.DateFromBottom.Margin = new System.Windows.Forms.Padding(1);
            this.DateFromBottom.Name = "DateFromBottom";
            this.DateFromBottom.Size = new System.Drawing.Size(148, 27);
            this.DateFromBottom.TabIndex = 30;
            this.DateFromBottom.Text = "";
            // 
            // DateToBottom
            // 
            this.DateToBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateToBottom.Location = new System.Drawing.Point(545, 30);
            this.DateToBottom.Margin = new System.Windows.Forms.Padding(1);
            this.DateToBottom.Name = "DateToBottom";
            this.DateToBottom.Size = new System.Drawing.Size(148, 27);
            this.DateToBottom.TabIndex = 32;
            this.DateToBottom.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.Controls.Add(this.DateToTop, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateFromTop, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.MonthlyCost, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeeklyCost, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.DailyCost, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.CarYear, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.CarTrim, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.CarType, 2, 1);
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
            this.tableLayoutPanel1.Controls.Add(this.BranchNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CarEngine, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClearTopButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 55);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // DateToTop
            // 
            this.DateToTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateToTop.Location = new System.Drawing.Point(883, 30);
            this.DateToTop.Margin = new System.Windows.Forms.Padding(1);
            this.DateToTop.Name = "DateToTop";
            this.DateToTop.Size = new System.Drawing.Size(211, 27);
            this.DateToTop.TabIndex = 42;
            this.DateToTop.Text = "";
            // 
            // DateFromTop
            // 
            this.DateFromTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateFromTop.Location = new System.Drawing.Point(733, 30);
            this.DateFromTop.Margin = new System.Windows.Forms.Padding(1);
            this.DateFromTop.Name = "DateFromTop";
            this.DateFromTop.Size = new System.Drawing.Size(148, 27);
            this.DateFromTop.TabIndex = 41;
            this.DateFromTop.Text = "";
            // 
            // MonthlyCost
            // 
            this.MonthlyCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyCost.Location = new System.Drawing.Point(639, 30);
            this.MonthlyCost.Margin = new System.Windows.Forms.Padding(1);
            this.MonthlyCost.Name = "MonthlyCost";
            this.MonthlyCost.Size = new System.Drawing.Size(92, 27);
            this.MonthlyCost.TabIndex = 40;
            this.MonthlyCost.Text = "";
            // 
            // WeeklyCost
            // 
            this.WeeklyCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeeklyCost.Location = new System.Drawing.Point(545, 30);
            this.WeeklyCost.Margin = new System.Windows.Forms.Padding(1);
            this.WeeklyCost.Name = "WeeklyCost";
            this.WeeklyCost.Size = new System.Drawing.Size(92, 27);
            this.WeeklyCost.TabIndex = 39;
            this.WeeklyCost.Text = "";
            // 
            // DailyCost
            // 
            this.DailyCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyCost.Location = new System.Drawing.Point(470, 30);
            this.DailyCost.Margin = new System.Windows.Forms.Padding(1);
            this.DailyCost.Name = "DailyCost";
            this.DailyCost.Size = new System.Drawing.Size(73, 27);
            this.DailyCost.TabIndex = 38;
            this.DailyCost.Text = "";
            // 
            // CarYear
            // 
            this.CarYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarYear.Location = new System.Drawing.Point(395, 30);
            this.CarYear.Margin = new System.Windows.Forms.Padding(1);
            this.CarYear.Name = "CarYear";
            this.CarYear.Size = new System.Drawing.Size(73, 27);
            this.CarYear.TabIndex = 37;
            this.CarYear.Text = "";
            // 
            // CarTrim
            // 
            this.CarTrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarTrim.Location = new System.Drawing.Point(320, 30);
            this.CarTrim.Margin = new System.Windows.Forms.Padding(1);
            this.CarTrim.Name = "CarTrim";
            this.CarTrim.Size = new System.Drawing.Size(73, 27);
            this.CarTrim.TabIndex = 36;
            this.CarTrim.Text = "";
            // 
            // CarType
            // 
            this.CarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarType.Location = new System.Drawing.Point(170, 30);
            this.CarType.Margin = new System.Windows.Forms.Padding(1);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(73, 27);
            this.CarType.TabIndex = 35;
            this.CarType.Text = "";
            this.CarType.TextChanged += new System.EventHandler(this.CarType_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(883, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Date-To-(DD/MM/YYYY)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(733, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Date-From-(DD/MM/YYYY)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(639, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Monthly Cost <=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(470, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Daily Cost <=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(395, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Car Year <=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(320, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Car Trim";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(245, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Car Engine";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(170, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Car Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTopButton
            // 
            this.SearchTopButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SearchTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchTopButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.SearchTopButton.ForeColor = System.Drawing.Color.White;
            this.SearchTopButton.Location = new System.Drawing.Point(1, 1);
            this.SearchTopButton.Margin = new System.Windows.Forms.Padding(1);
            this.SearchTopButton.Name = "SearchTopButton";
            this.SearchTopButton.Size = new System.Drawing.Size(92, 27);
            this.SearchTopButton.TabIndex = 0;
            this.SearchTopButton.Text = "Search";
            this.SearchTopButton.UseVisualStyleBackColor = false;
            this.SearchTopButton.Click += new System.EventHandler(this.SearchTopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(95, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(545, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Weekly Cost <=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchNum
            // 
            this.BranchNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BranchNum.Location = new System.Drawing.Point(95, 30);
            this.BranchNum.Margin = new System.Windows.Forms.Padding(1);
            this.BranchNum.Name = "BranchNum";
            this.BranchNum.Size = new System.Drawing.Size(73, 27);
            this.BranchNum.TabIndex = 32;
            this.BranchNum.Text = "";
            // 
            // CarEngine
            // 
            this.CarEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarEngine.Location = new System.Drawing.Point(245, 30);
            this.CarEngine.Margin = new System.Windows.Forms.Padding(1);
            this.CarEngine.Name = "CarEngine";
            this.CarEngine.Size = new System.Drawing.Size(73, 27);
            this.CarEngine.TabIndex = 33;
            this.CarEngine.Text = "";
            // 
            // ClearTopButton
            // 
            this.ClearTopButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClearTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearTopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearTopButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.ClearTopButton.ForeColor = System.Drawing.Color.White;
            this.ClearTopButton.Location = new System.Drawing.Point(1, 30);
            this.ClearTopButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearTopButton.Name = "ClearTopButton";
            this.ClearTopButton.Size = new System.Drawing.Size(92, 27);
            this.ClearTopButton.TabIndex = 43;
            this.ClearTopButton.Text = "Clear";
            this.ClearTopButton.UseVisualStyleBackColor = false;
            this.ClearTopButton.Click += new System.EventHandler(this.ClearTopButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 455);
            this.dataGridView1.TabIndex = 4;
            // 
            // EmployeeMainWindowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1096, 596);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "EmployeeMainWindowBook";
            this.Text = "Employee Window";
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
        private System.Windows.Forms.ToolStripMenuItem carTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox DateToTop;
        private System.Windows.Forms.RichTextBox DateFromTop;
        private System.Windows.Forms.RichTextBox MonthlyCost;
        private System.Windows.Forms.RichTextBox WeeklyCost;
        private System.Windows.Forms.RichTextBox DailyCost;
        private System.Windows.Forms.RichTextBox CarYear;
        private System.Windows.Forms.RichTextBox CarTrim;
        private System.Windows.Forms.RichTextBox CarType;
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
        private System.Windows.Forms.RichTextBox BranchNum;
        private System.Windows.Forms.RichTextBox CarEngine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox EmployeeID;
        private System.Windows.Forms.Button ClearBottomButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SelectBottomButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox CarVIN;
        private System.Windows.Forms.RichTextBox DateFromBottom;
        private System.Windows.Forms.RichTextBox DateToBottom;
        private System.Windows.Forms.Button ClearTopButton;
    }
}