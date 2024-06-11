using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class EmployeeMainWindowBook : Form
    {
        // get the string from form1
        public static string employeeLoggedInForm2 = LoginScreen.employeeLoggedIn;
        public static string carVINcarry, dateFromCarry, dateToCarry;
        public EmployeeMainWindowBook()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            bookEmployeeIDBox.Text = employeeLoggedInForm2;

            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            //// search through database
            //string query = "SELECT workatbranchnum FROM employees where employeeNum = '" + employeeLoggedInForm2 + "'";

            //using (con)
            //{
            //    SqlCommand com = new SqlCommand(query, con);
            //    //com.Parameters.Add();
            //}

            //SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            ////insert data from extracted sql

            //DataTable dtable = new DataTable();
            //adapter.Fill(dtable);

            //string branchBox = SearchBranchBox.Text;

            // search through database
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable cars = new DataTable();
            adapter.Fill(cars);

            dataGridView1.DataSource = cars;

            con.Dispose();
            con.Close();

            con.Close();
        }

        private void Search(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM car";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable cars = new DataTable();
                adapter.Fill(cars);

                dataGridView1.DataSource = cars;

                con.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void carTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM cartypes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable cartypes = new DataTable();
                adapter.Fill(cartypes);

                dataGridView1.DataSource = cartypes;

                con.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable customers = new DataTable();
                adapter.Fill(customers);

                dataGridView1.DataSource = customers;

                con.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable employees = new DataTable();
                adapter.Fill(employees);

                dataGridView1.DataSource = employees;

                con.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM rentaltransactions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable rentaltransactions = new DataTable();
                adapter.Fill(rentaltransactions);

                dataGridView1.DataSource = rentaltransactions;

                con.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                // search through database
                string query = "SELECT * FROM car";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable cars = new DataTable();
                adapter.Fill(cars);

                dataGridView1.DataSource = cars;

                con.Dispose();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeWindow_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void carsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveVehicle addVehicleForm = new AddRemoveVehicle();
            addVehicleForm.Show();
            this.Close();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveCustomer addCustomerForm = new AddRemoveCustomer();
            addCustomerForm.Show();
            this.Close();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveEmployee addRemoveEmployeeForm = new AddRemoveEmployee();
            addRemoveEmployeeForm.Show();
            this.Close();
        }

        private void SelectBottomButton_Click(object sender, EventArgs e)
        {
            // check if car is available at the indicated time
            // save car vin
            // open new customer window to search for customer info, or add new customer info
            // check to see what branch the car is in and where the customer wants to pick it up from
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBranchBox.Clear();
            SearchCarTypeBox.Clear();
            SearchCarEngineBox.Clear();
            SearchCarTrimBox.Clear();
            searchCarYearBox.Clear();
            searchDailyCostBox.Clear();
            SearchWeeklyCostBox.Clear();
            searchMonthlyCostBox.Clear();
            searchDateFromBox.Clear();
            searchDateToBox.Clear();

            SearchBranchBox.Focus();
        }

        private void ClearBottomButton_Click_1(object sender, EventArgs e)
        {
            bookCarVINBox.Clear();
            bookEmployeeIDBox.Clear();
            bookDateFromBox.Clear();
            bookDateToBox.Clear();

            bookCarVINBox.Focus();
        }

        private void SelectBottomButton_Click_1(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            // splitting the dates
            string[] carDateFrom = bookDateFromBox.Text.Split('/');
            string[] carDateTo = bookDateToBox.Text.Split('/');

            // check if car vin exists and is available
            String query = "SELECT * FROM cars, rentalTransactions WHERE carVIN = '" + bookCarVINBox.Text + "' AND " +
                "cars.'" + bookCarVINBox.Text + "' = rentalTransactions.'" + bookCarVINBox.Text + "' AND " +
                "rentalTransactions.'" + bookDateFromBox.Text + "' = rentalTransactions.'" + bookCarVINBox.Text + "' AND " +
                "'";



            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                carVINcarry = bookCarVINBox.Text;
                dateFromCarry = bookDateFromBox.Text;
                dateToCarry = bookDateToBox.Text;

                FindCustomerSmallWindow findCustomerSmallWindowForm = new FindCustomerSmallWindow();

                findCustomerSmallWindowForm.Show();

                con.Dispose();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Car VIN details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTopButton_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();


            con.Dispose();
            con.Close();
        }

        private void rentalTransactionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RentalTransactionWindowAddRemove rentalTransactionForm = new RentalTransactionWindowAddRemove();
            rentalTransactionForm.Show();
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add customer, switch forms
            AddNewCustomer addNewCustomerForm = new AddNewCustomer();
            addNewCustomerForm.Show();
        }

        private void bookDateFromBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove customer, switch forms
            DeleteCustomer deleteCustomerForm = new DeleteCustomer();
            deleteCustomerForm.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmployeeForm = new AddNewEmployee();
            addEmployeeForm.Show();
        }
    }
}
