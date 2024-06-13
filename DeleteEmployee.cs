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
    public partial class DeleteEmployee : Form
    {
        SqlCommand cmd;
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to delete Employee: '" + richTextBox4.Text + "'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                // connect to database
                SqlConnection con = new SqlConnection(LoginScreen.databasePath);
                con.Open();

                cmd = new SqlCommand("DELETE FROM customers WHERE cusid = '" + richTextBox4.Text + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee has been deleted, updating table");

                string query = "SELECT * FROM employees";

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
    }
}
