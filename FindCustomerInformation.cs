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
    public partial class FindCustomerInformation : Form
    {
        public FindCustomerInformation()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
            richTextBox7.Clear();
            richTextBox8.Clear();
            richTextBox9.Clear();
            richTextBox10.Clear();

            richTextBox7.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();

            richTextBox1.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalTransactionWindowAddRemove rentalTransactionForm = new RentalTransactionWindowAddRemove();
            rentalTransactionForm.Show();
            this.Close();
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeMainWindowBook employeeMainWindowBookForm = new EmployeeMainWindowBook();
            employeeMainWindowBookForm.Show();
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
