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
    public partial class TransactionsReceipt : Form
    {

        string dbForm2 = LoginScreen.databasePath;
        int transID;

        public TransactionsReceipt(int transID)
        {
            InitializeComponent();
            this.transID = transID;
            this.Load += new EventHandler(TransactionsReceipt_Load);
        }

        private void TransactionsReceipt_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbForm2))
            {
                con.Open();
                string query = "SELECT * FROM Customers WHERE CusID = (SELECT CusID FROM Rentaltransactions WHERE TransID = '" + this.transID + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int cusID = reader.GetInt32(reader.GetOrdinal("CusID"));
                    string operatorID = reader.GetString(reader.GetOrdinal("OperatorID"));
                    string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                    string dob = reader.GetString(reader.GetOrdinal("DOB"));
                    string contactNum = reader.GetString(reader.GetOrdinal("ContactNum"));
                    string street = reader.GetString(reader.GetOrdinal("Street"));
                    string city = reader.GetString(reader.GetOrdinal("City"));
                    string province = reader.GetString(reader.GetOrdinal("Province"));
                    string postalCode = reader.GetString(reader.GetOrdinal("PostalCode"));
                    string country = reader.GetString(reader.GetOrdinal("Country"));
                    string password = reader.GetString(reader.GetOrdinal("Password"));

                    CustomerName.Text = firstName + " " + lastName;
                    richTextBox3.Text = street + " " + city + " , " + province;
                    richTextBox4.Text = contactNum; 
                    richTextBox2.Text = operatorID; 

                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
