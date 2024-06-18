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
    public partial class TransactionPaymentWindow : Form
    {
        // Retrieve databasePath from LoginScreen
        string dbForm2 = "Data Source=LAPTOP-7KGL33RR;Initial Catalog=291;Integrated Security=True;Encrypt=False";
        private string customerID;

        public TransactionPaymentWindow(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            PopulateCarComboBox();
        }

        private void TransactionPaymentWindow_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Would you like to return to the previous menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                CustomerWindow cusWindow = new CustomerWindow(customerID, dbForm2);
                cusWindow.Show();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Populate drop down with all cars
        private void PopulateCarComboBox()
        {
            SqlConnection con = new SqlConnection(dbForm2);
            try
            {
                con.Open();
                string query = "SELECT carVIN, brand, model, year FROM Car;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string carDetails = $"{row["carVIN"]} - {row["brand"]} {row["model"]} ({row["year"]})"; //color
                    comboBox1.Items.Add(carDetails);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching car data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //Back button to return to previous page
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Would you like to return to the previous menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                CustomerWindow cusWindow = new CustomerWindow(customerID, dbForm2);
                cusWindow.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Retrieve selected car details from comboBox1
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle to rent.");
                return;
            }

            string selectedCar = comboBox1.SelectedItem.ToString();
            string carVIN = selectedCar.Split('-')[0].Trim(); // Assuming carVIN is the first part of the string

            // Retrieve rental dates from dateTimePickers
            DateTime rentalStartDate = dateTimePicker1.Value;
            DateTime rentalEndDate = dateTimePicker2.Value;

            // Retrieve customer details
            string customerName = textBoxName.Text;
            string customerAddress = textBoxAddress.Text;
            string customerLicenseNumber = textBoxLicense.Text;

            //// Ensure customerID is set properly
            //if (string.IsNullOrEmpty(customerID))
            //{
            //    MessageBox.Show("Customer ID is not set. Please ensure the customer is logged in.");
            //    return;
            //}

            // Placeholder values for branch numbers and employee number for testing
            int branchNum = 1;
            int branchDropoff = 1;
            int employeeNum = 1;

            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Database connection opened");

                    // Check if the car is available during the specified dates
                    string checkAvailabilityQuery = @"
                        SELECT COUNT(*)
                        FROM RentalTransactions
                        WHERE carVIN = @carVIN
                        AND NOT (
                            @rentalEndDate < rentedFromDate OR
                            @rentalStartDate > returnToDate
                        )";

                    SqlCommand checkCmd = new SqlCommand(checkAvailabilityQuery, con);
                    checkCmd.Parameters.AddWithValue("@carVIN", carVIN);
                    checkCmd.Parameters.AddWithValue("@rentalStartDate", rentalStartDate);
                    checkCmd.Parameters.AddWithValue("@rentalEndDate", rentalEndDate);

                    int existingBookings = (int)checkCmd.ExecuteScalar();

                    if (existingBookings > 0)
                    {
                        MessageBox.Show("The car is not available during the specified dates.");
                        return;
                    }

                    // Retrieve the current maximum transID
                    string getMaxTransIdQuery = "SELECT MAX(transID) FROM RentalTransactions";
                    SqlCommand getMaxTransIdCmd = new SqlCommand(getMaxTransIdQuery, con);
                    int maxTransId = (int)getMaxTransIdCmd.ExecuteScalar();
                    int newTransId = maxTransId + 1;

                    // Insert into RentalTransactions table including transID
                    string query = "INSERT INTO RentalTransactions (transID, rentalCost, rentedFromDate, returnToDate, employeeNum, cusID, carVIN, branchNum, branchDropoff) " +
                                   "VALUES (@transID, @rentalCost, @rentedFromDate, @returnToDate, @employeeNum, @cusID, @carVIN, @branchNum, @branchDropoff)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Placeholder values for testing
                    cmd.Parameters.AddWithValue("@transID", newTransId);
                    cmd.Parameters.AddWithValue("@rentalCost", 0);
                    cmd.Parameters.AddWithValue("@rentedFromDate", rentalStartDate);
                    cmd.Parameters.AddWithValue("@returnToDate", rentalEndDate);
                    cmd.Parameters.AddWithValue("@employeeNum", employeeNum);
                    cmd.Parameters.AddWithValue("@cusID", customerID);
                    cmd.Parameters.AddWithValue("@carVIN", carVIN);
                    cmd.Parameters.AddWithValue("@branchNum", branchNum);
                    cmd.Parameters.AddWithValue("@branchDropoff", branchDropoff);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Booking created");

                    MessageBox.Show("Booking created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the booking: " + ex.Message);
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Console.WriteLine("Database connection closed");
                }
            }
        }
    }
}
