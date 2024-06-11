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
    public partial class AddRemoveVehicle : Form
    {
        SqlCommand cmd;
        public AddRemoveVehicle()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void AddVehicleClearButton(object sender, EventArgs e)
        {

        }

        private void DeleteVehicleClearButton(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolBarDatabaseCars(object sender, EventArgs e)
        {
            EmployeeMainWindowBook employeeMainWindowBookForm = new EmployeeMainWindowBook();
            employeeMainWindowBookForm.Show();
            this.Close();
        }

        private void addCarVINtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCarAddButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchCarButton(object sender, EventArgs e)
        {

        }
        // delete vehicle here
        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            cmd = new SqlCommand("DELETE FROM car WHERE CarVIN = '"+deleteCarVINtxt.Text+"'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data has been deleted, updating table");

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // page that needed to be loaded next
            AddRemoveCustomer addRemoveCustomerForm = new AddRemoveCustomer();
            addRemoveCustomerForm.Show();

            this.Close();
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

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRemoveEmployee addRemoveEmployeeForm = new AddRemoveEmployee();
            addRemoveEmployeeForm.Show();
            this.Close();
        }

        private void deleteCarVINtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addCarClearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void searchCarClearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCarVINtxt.Clear();
            addCarTypeIDtxt.Clear();
            addCarBrandtxt.Clear();
            addCarModeltxt.Clear();
            addCarYeartxt.Clear();
            addCarColortxt.Clear();
            addCarMileagetxt.Clear();
            addCarLastTuneUptxt.Clear();
            addCarConditiontxt.Clear();
            addCarBranchLocationtxt.Clear();

            addCarVINtxt.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchCarVINtxt.Clear();
            searchCarTypeIDtxt.Clear();
            searchCarBrandtxt.Clear();
            searchCarModeltxt.Clear();
            searchCarYeartxt.Clear();
            searchCarColortxt.Clear();
            searchCarMileagetxt.Clear();
            searchCarLastTuneUptxt.Clear();
            searchCarConditiontxt.Clear();
            searchCarBranchLocationtxt.Clear();

            searchCarVINtxt.Focus();
        }

        private void addCarVINtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        // add vehicle button
        private void button3_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            cmd = new SqlCommand("INSERT INTO car values('" + addCarVINtxt.Text + "'," +
                " '" + addCarTypeIDtxt.Text + "'," +
                " '" + addCarBrandtxt.Text + "', " +
                " '" + addCarModeltxt.Text + "'," +
                " '" + addCarYeartxt.Text + "'," +
                " '" + addCarColortxt.Text + "'," +
                " '" + addCarMileagetxt.Text + "'," +
                " '" + addCarLastTuneUptxt.Text + "'," +
                " '" + addCarConditiontxt.Text + "'," +
                " '" + addCarBranchLocationtxt.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data has been inserted, updating table");

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        // search add and remove
        private void button1_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            con.Close();
        }

        private void rentalTransactionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RentalTransactionWindowAddRemove rentalTransactionForm = new RentalTransactionWindowAddRemove();
            rentalTransactionForm.Show();
            this.Close();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmployeeForm = new AddNewEmployee();
            addEmployeeForm.Show();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add customer, switch forms
            AddNewCustomer addNewCustomerForm = new AddNewCustomer();
            addNewCustomerForm.Show();
        }

        private void removeCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove customer, switch forms
            DeleteCustomer deleteCustomerForm = new DeleteCustomer();
            deleteCustomerForm.Show();
        }
    }
}
