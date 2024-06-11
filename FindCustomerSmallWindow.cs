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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cmpt291UI
{
    public partial class FindCustomerSmallWindow : Form
    {
        bool firstClick = true;
        public FindCustomerSmallWindow()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            string query = "SELECT cusID, firstName, lastName, contactNum FROM customers";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable customerList = new DataTable();
            adapter.Fill(customerList);

            dataGridView1.DataSource = customerList;

            con.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomerForm = new AddNewCustomer();
            addNewCustomerForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            TransactionPaymentWindow transactionPaymentForm = new TransactionPaymentWindow();
            transactionPaymentForm.Show();

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (firstClick)
            {
                richTextBox3.Text = string.Empty;
                firstClick = false;
            }
        }
    }
}
