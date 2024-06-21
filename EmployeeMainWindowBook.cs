using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class EmployeeMainWindowBook : Form
    {
        // get the string from form1

        string dbForm2 = "Data Source=DESKTOP-3PU7T29;Initial Catalog=CMPT291;Integrated Security=True;Encrypt=False";
        string employeeLoggedInForm2 = LoginScreen.employeeLoggedIn;
        public EmployeeMainWindowBook()
        {
            InitializeComponent();
            EmployeeID.Text = employeeLoggedInForm2;

            // connect to database
            SqlConnection con = new SqlConnection(dbForm2);
            con.Open();

            // search through database
            string query = "SELECT workatbranchnum FROM employees where employeeNum = '" + employeeLoggedInForm2 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            BranchNum.Text = dtable.ToString();

            con.Close();
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM car";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable cars = new DataTable();
                adapter.Fill(cars);

                dataGridView1.DataSource = cars;

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
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM cartypes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable cartypes = new DataTable();
                adapter.Fill(cartypes);

                dataGridView1.DataSource = cartypes;

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
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable customers = new DataTable();
                adapter.Fill(customers);

                dataGridView1.DataSource = customers;

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
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable employees = new DataTable();
                adapter.Fill(employees);

                dataGridView1.DataSource = employees;

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
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM rentaltransactions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable rentaltransactions = new DataTable();
                adapter.Fill(rentaltransactions);

                dataGridView1.DataSource = rentaltransactions;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Would you like to return to the login screen?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                LoginScreen Login = new LoginScreen();
                Login.Show();
            }
        }

      

        private void carsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveVehicle addVehicleForm = new AddRemoveVehicle();
            addVehicleForm.Show();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmployeeForm = new AddNewEmployee();
            addEmployeeForm.Show();
            this.Hide();
        }

        private void SelectBottomButton_Click(object sender, EventArgs e)
        {
            // check if car is available at the indicated time
            // save car vin
            // open new customer window to search for customer info, or add new customer info
            // check to see what branch the car is in and where the customer wants to pick it up from
        }

        private void ClearBottomButton_Click(object sender, EventArgs e)
        {
            DateFromBottom.Clear();
            EmployeeID.Clear();
            CarVIN.Clear();
            DateToBottom.Clear();
            DateFromBottom.Clear();
        }

        private void SearchTopButton_Click(object sender, EventArgs e)
        {
            SearchDatabase();
        }

        private void ClearTopButton_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            BranchNum.Clear();
            CarType.Clear();
            CarEngine.Clear();
            CarTrim.Clear();
            CarYear.Clear();
            DailyCost.Clear();
            WeeklyCost.Clear();
            MonthlyCost.Clear();
            DateFromTop.Clear();
            DateToTop.Clear();
        }

        private void SearchDatabase()
        {
            // Retrieve data from textboxes
            string branchNum = BranchNum.Text;
            string carType = CarType.Text;
            string carEngine = CarEngine.Text;
            string carTrim = CarTrim.Text;
            string carYear = CarYear.Text;
            string dailyCost = DailyCost.Text;
            string weeklyCost = WeeklyCost.Text;
            string monthlyCost = MonthlyCost.Text;
            string dateFromTop = DateFromTop.Text;
            string dateToTop = DateToTop.Text;

            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                try
                {
                    con.Open();

                    // Construct SQL query dynamically based on non-empty fields
                    StringBuilder query = new StringBuilder("SELECT * FROM Car WHERE 1=1");

                    if (!string.IsNullOrEmpty(branchNum)) query.Append(" AND branchNum = @branchNum");
                    if (!string.IsNullOrEmpty(carType)) query.Append(" AND carType = @carType");
                    if (!string.IsNullOrEmpty(carEngine)) query.Append(" AND carEngine = @carEngine");
                    if (!string.IsNullOrEmpty(carTrim)) query.Append(" AND carTrim = @carTrim");
                    if (!string.IsNullOrEmpty(carYear)) query.Append(" AND carYear = @carYear");
                    if (!string.IsNullOrEmpty(dailyCost)) query.Append(" AND dailyCost = @dailyCost");
                    if (!string.IsNullOrEmpty(weeklyCost)) query.Append(" AND weeklyCost = @weeklyCost");
                    if (!string.IsNullOrEmpty(monthlyCost)) query.Append(" AND monthlyCost = @monthlyCost");
                    if (!string.IsNullOrEmpty(dateFromTop)) query.Append(" AND availableFromDate <= @dateFromTop");
                    if (!string.IsNullOrEmpty(dateToTop)) query.Append(" AND availableToDate >= @dateToTop");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);

                    // Add parameters to the command
                    if (!string.IsNullOrEmpty(branchNum)) cmd.Parameters.AddWithValue("@branchNum", branchNum);
                    if (!string.IsNullOrEmpty(carType)) cmd.Parameters.AddWithValue("@carType", carType);
                    if (!string.IsNullOrEmpty(carEngine)) cmd.Parameters.AddWithValue("@carEngine", carEngine);
                    if (!string.IsNullOrEmpty(carTrim)) cmd.Parameters.AddWithValue("@carTrim", carTrim);
                    if (!string.IsNullOrEmpty(carYear)) cmd.Parameters.AddWithValue("@carYear", carYear);
                    if (!string.IsNullOrEmpty(dailyCost)) cmd.Parameters.AddWithValue("@dailyCost", dailyCost);
                    if (!string.IsNullOrEmpty(weeklyCost)) cmd.Parameters.AddWithValue("@weeklyCost", weeklyCost);
                    if (!string.IsNullOrEmpty(monthlyCost)) cmd.Parameters.AddWithValue("@monthlyCost", monthlyCost);
                    if (!string.IsNullOrEmpty(dateFromTop)) cmd.Parameters.AddWithValue("@dateFromTop", dateFromTop);
                    if (!string.IsNullOrEmpty(dateToTop)) cmd.Parameters.AddWithValue("@dateToTop", dateToTop);

                    // Execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    // Display the results in a DataGridView or other suitable control
                    dataGridView1.DataSource = results;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
        }

        private void CarType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}