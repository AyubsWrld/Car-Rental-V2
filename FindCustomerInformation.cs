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
        string findCustomerInfoDBForm = LoginScreen.databasePath;
        //string employeeLoggedInForm2 = LoginScreen.employeeLoggedIn;
        public FindCustomerInformation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(findCustomerInfoDBForm);
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
    }
}
