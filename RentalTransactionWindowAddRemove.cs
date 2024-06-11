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
    public partial class RentalTransactionWindowAddRemove : Form
    {
        SqlCommand cmd;
        public RentalTransactionWindowAddRemove()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            string query = "SELECT * FROM rentaltransactions";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable rentalTransactionsList = new DataTable();
            adapter.Fill(rentalTransactionsList);

            dataGridView1.DataSource = rentalTransactionsList;

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteRentalTransaction(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            cmd = new SqlCommand("DELETE FROM rentalTransactions WHERE transID = '" + richTextBox21.Text + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Transaction has been deleted, updating table");

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM rentaltransactions";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable rentalTransactionsList = new DataTable();
            adapter.Fill(rentalTransactionsList);

            dataGridView1.DataSource = rentalTransactionsList;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookCarStrip(object sender, EventArgs e)
        {
            // page that needed to be loaded next
            EmployeeMainWindowBook employeeMainWindowBookForm = new EmployeeMainWindowBook();
            employeeMainWindowBookForm.Show();
            this.Close();
        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AddRemoveVehicle addVehicleForm = new AddRemoveVehicle();
            addVehicleForm.Show();
            this.Close();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add customer, switch forms
            AddNewCustomer addNewCustomerForm = new AddNewCustomer();
            addNewCustomerForm.Show();
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
