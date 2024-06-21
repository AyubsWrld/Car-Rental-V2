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
    public partial class CustomerWindow : Form
    {
<<<<<<< HEAD
        string databasePath = "Data Source=DESKTOP-3PU7T29;Initial Catalog=CMPT291;Integrated Security=True;Encrypt=False";
=======
        public static string databasePath = "Data Source=LAPTOP-MID32020;Initial Catalog=291_FinalProject;Integrated Security=True;Encrypt=False";
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961

        private string customerID;
        public class Car
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Year { get; set; }
            public string Engine { get; set; }
            public string Color { get; set; }
            public Image Image { get; set; }
        }

        private List<Car> cars;
        private int currentCarIndex = 0;
        private System.Windows.Forms.Timer timer1;
        private string CustomerName;

        public CustomerWindow(string customerID, string databasePath)
        {
            this.CustomerName = GetNameFromDatabase(customerID, databasePath);
            this.customerID = customerID;
            InitializeComponent();
            LoadCars();
            InitializeTimer();
            DisplayCarDetails(currentCarIndex);
            UserName.Text = CustomerName;
        }


        private string GetNameFromDatabase(string customerID, string databasePath)
        {
            string name = string.Empty;
            try
            {
                // Connect to the database
                using (SqlConnection con = new SqlConnection(databasePath))
                {
                    con.Open();
                    // Search through the database for the customer's name based on customerID
                    string query = $"SELECT fname FROM Customers WHERE cusID = '{customerID}'";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the name from the database
                                name = reader["fname"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to find name. " + ex.Message);
            }

            return name;
        }


        private void LoadCars()
        {
            string imgPath = @"C:\Users\Ayub Haji\Desktop\CMPT 291\Final Project\Final Project\img";
            cars = new List<Car>
            {
            new Car { Name = "Honda Accord", Type = "Sedan", Year = 2020, Engine = "Gas", Color = "Black", Image = LoadImage(Path.Combine(imgPath, "Honda_Accord_2020_Black.jpg"))},
            new Car { Name = "Volkswagen Beetle", Type = "Sedan", Year = 2019, Engine = "Gas", Color = "White", Image = LoadImage(Path.Combine(imgPath, "Volkswagen_Beetle_2019_White.jpg"))},
            new Car { Name = "Chevrolet Volt", Type = "Sedan", Year = 2023, Engine = "Electric", Color = "White", Image = LoadImage(Path.Combine(imgPath, "Chevrolet_Volt_2023_White.jpg"))},
            new Car { Name = "BMW X5", Type = "SUV", Year = 2023, Engine = "Gas", Color = "Black", Image = LoadImage(Path.Combine(imgPath, "BMW_X5_2023_Black.jpg"))},
            new Car { Name = "Ford F-150", Type = "Truck", Year = 2019, Engine = "Gas", Color = "Blue", Image = LoadImage(Path.Combine(imgPath, "Ford_F-150_2019_Blue.jpg"))},
            new Car { Name = "Ford Mustang", Type = "Sport", Year = 2023, Engine = "Gas", Color = "Grey", Image = LoadImage(Path.Combine(imgPath, "Ford_Mustang_2023_Grey.jpg"))},
            new Car { Name = "Lincoln Navigator", Type = "SUV", Year = 2022, Engine = "Gas", Color = "Blue", Image = LoadImage(Path.Combine(imgPath, "Lincoln_Navigator_ 2022_Blue.jpg"))},
            new Car { Name = "Rivian R1T", Type = "Truck", Year = 2024, Engine = "Electric", Color = "White", Image = LoadImage(Path.Combine(imgPath, "Rivian_R1T_2024_White.jpg"))},
            };

        }

        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000; // 5 seconds
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Start();
        }

        private Image LoadImage(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File not found: {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // or a default image
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {path}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // or a default image
            }
        }

        private void DisplayCarDetails(int index)
        {
            if (index < 0 || index >= cars.Count)
                return;

            Car car = cars[index];
            pictureBox1.Image = car.Image;
            CarName.Text = car.Name;
            CarTrim.Text = car.Type;
            CarYear.Text = car.Year.ToString();
            CarEngine.Text = car.Engine;
            CarColor.Text = car.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentCarIndex++;
            if (currentCarIndex >= cars.Count)
                currentCarIndex = 0;
            DisplayCarDetails(currentCarIndex);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            WelcomeScreenCustomer goBack = new WelcomeScreenCustomer();
            this.Hide();
            goBack.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TransactionPaymentWindow paymentWindow = new TransactionPaymentWindow(customerID);
            paymentWindow.Show();
            this.Hide();
        }

        private void rentalsBtn_Click(object sender, EventArgs e)
        {
            ReceiptList receiptList = new ReceiptList();
            receiptList.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void Title_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
    }
}
