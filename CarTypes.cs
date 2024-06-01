using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace Cmpt291UI
{
    public partial class RentalQuery : Form
    {
        public RentalQuery()
        {
            InitializeComponent();
        }
        public string databasePath = "Data Source=DESKTOP-SG96S0F;Initial Catalog=cmpt291;Integrated Security=True;Encrypt=False";
        private void CarToolBox(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(databasePath);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Cars", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                }

                string selectquery = "select * from Cars";
                MessageBox.Show("Error2");
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
                DataTable table = new DataTable();
                MessageBox.Show("Error3");
                // breaks here
                adpt.Fill(table);
                MessageBox.Show("Error4");
                results.DataSource = table;
                results.AutoResizeColumns();

                /*
                cmd = new SqlCommand("Select * from Cars", con);
                string query = "Select * from Cars";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter a = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();

                a.SelectCommand = cmd;
                a.Fill(dt);

                results.DataSource = dt;
                results.AutoResizeColumns();
                */
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void RentalQuery_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void dataGridViewShowCarInfo(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton(object sender, EventArgs e)
        {

        }

        private void CarTypeToolBox_Click(object sender, EventArgs e)
        {

        }

        private void CustomerToolBox_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesToolBox_Click(object sender, EventArgs e)
        {

        }

        private void RentalTransactionToolBox_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
