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

                string query = "select * from cars";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

                //sqlcommandbuilder commandbuilder = new sqlcommandbuilder();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Select * from Cars";
                //cmd.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //SqlDataAdapter datadp = new SqlDataAdapter(cmd);
                //results.Fill(dt);

                //SqlCommand cmd = new SqlCommand("select * from Cars", con);
                //SqlDataReader reader = cmd.ExecuteReader();

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



        public void dataGridViewShowCarInfo(object sender, DataGridViewCellEventArgs e)
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
