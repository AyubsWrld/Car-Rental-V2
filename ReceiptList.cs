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
    public partial class ReceiptList : Form
    {
        string dbForm2 = LoginScreen.databasePath;

        public ReceiptList()
        {
            InitializeComponent();
            LoadData();

            // Add event handler for DataGridView CellContentClick event
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void LoadData()
        {
            try
            {
                // connect to database
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();

                // search through database
                string query = "SELECT * FROM rentaltransactions WHERE cusID = " + WelcomeScreenCustomer.customerID;
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable rentaltransactions = new DataTable();
                adapter.Fill(rentaltransactions);

                dataGridView1.DataSource = rentaltransactions;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Get the TransID of the selected row
                    int transID = Convert.ToInt32(row.Cells["TransID"].Value);

                    // Delete the row from DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Delete the corresponding entry from the database
                    DeleteTransaction(transID);
                }
            }
        }

        private void DeleteTransaction(int transID)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbForm2);
                con.Open();
                string query = "DELETE FROM rentaltransactions WHERE TransID = @TransID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TransID", transID);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void returnOpt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int transID = Convert.ToInt32(selectedRow.Cells["TransID"].Value);

                using (SqlConnection con = new SqlConnection(dbForm2))
                {
                    con.Open();
                    string query = "SELECT BranchNum FROM Rentaltransactions WHERE CusID = '" + WelcomeScreenCustomer.customerID + "' AND TransID = '" + transID + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int branchNum = Convert.ToInt32(result);
                        // Confirm deletion
                        BranchInputForm form = new BranchInputForm(transID, branchNum);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("BranchNum not found for CusID and TransID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a car to return.");
            }
        }

        private void viewReciept_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int transID = Convert.ToInt32(selectedRow.Cells["TransID"].Value);
                TransactionsReceipt Receipt = new TransactionsReceipt(transID);
                Receipt.Show();
            }
            else
            {
                MessageBox.Show("Please select a transaction to view the receipt.");
            }
        }


    }
}

