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
    public partial class DeleteCustomer : Form
    {
        bool firstClickConNum = true;

        SqlCommand cmd;
        public DeleteCustomer()
        {
            InitializeComponent();

            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to delete Customer: '" + richTextBox4.Text + "'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                cmd = new SqlCommand("DELETE FROM customers WHERE cusid = '" + richTextBox4.Text + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer has been deleted, updating table");

                string query = "SELECT * FROM customers";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // insert data from extracted sql
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                dataGridView1.DataSource = dtable;

                con.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            con.Close();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (firstClickConNum)
            {
                richTextBox3.Text = string.Empty;
                richTextBox3.ForeColor = Color.Black;
                firstClickConNum = false;
            }
        }
    }
}
