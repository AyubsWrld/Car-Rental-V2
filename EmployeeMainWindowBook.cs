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
        string dbForm2 = LoginScreen.databasePath;
        string employeeLoggedInForm2 = LoginScreen.employeeLoggedIn;
        public EmployeeMainWindowBook()
        {
            InitializeComponent();
            richTextBox13.Text = employeeLoggedInForm2;

            // connect to database
            SqlConnection con = new SqlConnection(dbForm2);
            con.Open();

            // search through database
            string query = "SELECT workatbranchnum FROM employees where employeeNum = '" + employeeLoggedInForm2 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            richTextBox1.Text = dtable.ToString();

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


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
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
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveCustomer addCustomerForm = new AddRemoveCustomer();
            addCustomerForm.Show();
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmployeeForm = new AddNewEmployee();
            addEmployeeForm.Show();
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
            richTextBox12.Clear();
            richTextBox13.Clear();
            // Debug
            //richTextBox15.Clear();
            //richTextBox16.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
