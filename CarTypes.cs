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
using System.Data.OleDb;
using System.CodeDom.Compiler;

namespace Cmpt291UI
{
    public partial class RentalQuery : Form
    {
        public RentalQuery()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SG96S0F;Initial Catalog=cmpt291;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //con = new SqlConnection(@"Data Source=DESKTOP-SG96S0F;Initial Catalog=cmpt291;Integrated Security=True;Encrypt=False");
                //cmd = new SqlCommand("select * from Cars", con);
                string selectquery = "select * from Cars";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
                DataTable table = new DataTable();
                adpt.Fill(table);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
