using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class TransactionPaymentWindow : Form
    {
        string dbForm2 = "Data Source=LAPTOP-MID32020;Initial Catalog=291_FinalProject;Integrated Security=True;Encrypt=False";
        private string customerID;
        private DateTime rentalStartDate;
        private DateTime rentalEndDate;
        private string carVIN;

        public TransactionPaymentWindow(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            PopulateCarComboBox();
            PopulateCustomerDetails();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; // ComboBox event handler
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged; //dataTimePicker 1 event handler
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged; //dataTimePicker 2 event handler
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalBalance();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalBalance();
        }

        private void UpdateTotalBalance()
        {
            if (comboBox1.SelectedItem == null)
                return;

            string selectedCar = comboBox1.SelectedItem.ToString();
            string carVIN = selectedCar.Split('-')[0].Trim(); // Assuming carVIN is the first part of the string

            DateTime rentalStartDate = dateTimePicker1.Value;
            DateTime rentalEndDate = dateTimePicker2.Value;

            // Ensure the rental start date is before the end date
            if (rentalStartDate > rentalEndDate)
            {
                MessageBox.Show("The rental start date must be before the end date.");
                return;
            }

            // Calculate the number of rental days
            TimeSpan rentalDuration = rentalEndDate - rentalStartDate;
            int rentalDays = rentalDuration.Days + 1; // Including the end date

            // Retrieve the daily cost for the selected car
            int dailyCost = GetDailyCost(carVIN);

            if (dailyCost < 0)
            {
                MessageBox.Show("An error occurred while retrieving the daily cost.");
                return;
            }

            // Calculate the total cost
            int totalCost = rentalDays * dailyCost;

            // Display the total cost in the TotalBalance textbox
            TotalBalance.Text = totalCost.ToString();
        }


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
                    string carDetails = $"{row["carVIN"]} - {row["brand"]} {row["model"]} ({row["year"]})";
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

        private void PopulateCustomerDetails()
        {
            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                try
                {
                    con.Open();
                    string query = "SELECT fname, street, city, province, postalCode, contactNum FROM Customers WHERE cusID = @cusID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cusID", customerID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxName.Text = reader["fname"].ToString();
                            string address = $"{reader["street"]}, {reader["city"]}, {reader["province"]}, {reader["postalCode"]}";
                            Address.Text = address;
                            ContactNum.Text = reader["contactNum"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching customer details: " + ex.Message);
                }
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

            // Ensure the rental start date is before the end date
            if (rentalStartDate > rentalEndDate)
            {
                MessageBox.Show("The rental start date must be before the end date.");
                return;
            }

            // Calculate the number of rental days
            TimeSpan rentalDuration = rentalEndDate - rentalStartDate;
            int rentalDays = rentalDuration.Days + 1; // Including the end date

            // Retrieve the daily cost for the selected car
            int dailyCost = GetDailyCost(carVIN);

            if (dailyCost < 0)
            {
                MessageBox.Show("An error occurred while retrieving the daily cost.");
                return;
            }

            // Calculate the total cost
            int totalCost = rentalDays * dailyCost;

            // Display the total cost in the TotalBalance textbox
            TotalBalance.Text = totalCost.ToString();

            // Store the total cost in the rentalCost column
            StoreRentalCostInDatabase(totalCost);

            // Display success message
            MessageBox.Show("Booking created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StoreRentalCostInDatabase(int totalCost)
        {
            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                try
                {
                    con.Open();

                    // Retrieve the current maximum transID
                    string getMaxTransIdQuery = "SELECT MAX(transID) FROM RentalTransactions";
                    SqlCommand getMaxTransIdCmd = new SqlCommand(getMaxTransIdQuery, con);
                    int maxTransId = (int)getMaxTransIdCmd.ExecuteScalar();
                    int newTransId = maxTransId + 1;

                    // Insert into RentalTransactions table including transID
                    string query = "INSERT INTO RentalTransactions (transID, rentalCost, rentedFromDate, returnToDate, employeeNum, cusID, carVIN, branchNum, branchDropoff) " +
                                   "VALUES (@transID, @rentalCost, @rentedFromDate, @returnToDate, @employeeNum, @cusID, @carVIN, @branchNum, @branchDropoff)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@transID", newTransId);
                    cmd.Parameters.AddWithValue("@rentalCost", totalCost);
                    cmd.Parameters.AddWithValue("@rentedFromDate", rentalStartDate);
                    cmd.Parameters.AddWithValue("@returnToDate", rentalEndDate);
                    cmd.Parameters.AddWithValue("@employeeNum", 1); // Placeholder value
                    cmd.Parameters.AddWithValue("@cusID", customerID);
                    cmd.Parameters.AddWithValue("@carVIN", carVIN);
                    cmd.Parameters.AddWithValue("@branchNum", 1); // Placeholder value
                    cmd.Parameters.AddWithValue("@branchDropoff", 1); // Placeholder value

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the booking: " + ex.Message);
                }
            }
        }

        private int GetDailyCost(string carVIN)
        {
            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                try
                {
                    con.Open();
                    string query = @" SELECT ct.dailyCost FROM Car c INNER JOIN CarTypes ct ON c.carTypeID = ct.carTypeID WHERE c.carVIN = @carVIN";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@carVIN", carVIN);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve the daily cost for the selected car.");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the daily cost: " + ex.Message);
                    return -1;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            UpdateTotalBalance();
        }
    }
}
