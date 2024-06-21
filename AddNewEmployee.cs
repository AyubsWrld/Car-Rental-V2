using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class AddNewEmployee : Form
    {
        // Database connection string
        string dbConnectionString = "Data Source=LAPTOP-MID32020;Initial Catalog=291_FinalProject;Integrated Security=True;Encrypt=False";

        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            int day = int.Parse(Day.Text);
            int month = int.Parse(Month.Text);
            int year = int.Parse(Year.Text);
            string contactNum = ContactNum.Text;
            string street = Street.Text;
            string city = City.Text;
            string province = Province.Text;
            string postalCode = PostalCode.Text;
            string country = Country.Text;
            int branchNum = int.Parse(BranchNum.Text);
            string password = PasswordBox.Text;

            // Combine date parts into a single DateTime object
            DateTime birthDate = new DateTime(year, month, day);

            using (SqlConnection con = new SqlConnection(dbConnectionString))
            {
                try
                {
                    con.Open();

                    // Retrieve the current maximum employeeNum
                    string getMaxEmployeeNumQuery = "SELECT MAX(employeeNum) FROM Employees";
                    SqlCommand getMaxEmployeeNumCmd = new SqlCommand(getMaxEmployeeNumQuery, con);
                    int maxEmployeeNum = (int)getMaxEmployeeNumCmd.ExecuteScalar();
                    int newEmployeeNum = maxEmployeeNum + 1;

                    // Insert data into the Employees table
                    string query = "INSERT INTO Employees (employeeNum, fname, lname, DOB, contactNum, street, city, province, postalCode, country, password, workAtBranchNum) " +
                                   "VALUES (@employeeNum, @firstName, @lastName, @birthDate, @contactNum, @street, @city, @province, @postalCode, @country, @password, @branchNum)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@employeeNum", newEmployeeNum);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@birthDate", birthDate.ToString("dd-MM-yyyy"));
                    cmd.Parameters.AddWithValue("@contactNum", contactNum);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@postalCode", postalCode);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@branchNum", branchNum);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee signed up successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear all textboxes after successful submission
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while signing up the employee: " + ex.Message);
                }
            }
        }


        private void ClearTextBoxes()
        {
            // Clear all textboxes
            FirstName.Clear();
            LastName.Clear();
            Day.Clear();
            Month.Clear();
            Year.Clear();
            ContactNum.Clear();
            Street.Clear();
            City.Clear();
            Province.Clear();
            PostalCode.Clear();
            Country.Clear();
            BranchNum.Clear();
            PasswordBox.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            FirstName.Clear();
            LastName.Clear();
            Day.Clear();
            Month.Clear();
            Year.Clear();
            ContactNum.Clear();
            Street.Clear();
            City.Clear();
            Province.Clear();
            PostalCode.Clear();
            Country.Clear();
            BranchNum.Clear();
            PasswordBox.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
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
    }
}