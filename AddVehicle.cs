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
    public partial class AddVehicle : Form
    {
        string addVehicleDBForm = LoginScreen.databasePath;
        SqlCommand cmd;
        public AddVehicle()
        {
            InitializeComponent();

            // connect to database
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();

            // search through database
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void AddVehicleClearButton(object sender, EventArgs e)
        {

        }

        private void DeleteVehicleClearButton(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();

            // search through database
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void addCarVINtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCarAddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();

            cmd = new SqlCommand("INSERT INTO car values('" + addCarVINtxt.Text + "'," +
                " '" + addCarTypeIDtxt.Text + "'," +
                " '" + addCarBrandtxt.Text + "', " +
                " '" + addCarModeltxt.Text + "'," +
                " '" + addCarYeartxt.Text + "'," +
                " '" + addCarColortxt.Text + "'," +
                " '" + addCarMileagetxt.Text + "'," +
                " '" + addCarLastTuneUptxt.Text + "'," +
                " '" + addCarConditiontxt.Text + "'," +
                " '" + addCarBranchLocationtxt.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data has been inserted");

            con.Close();
        }

        private void deleteCarDeleteButton_Click(object sender, EventArgs e)
        {
            // delete vehicle here
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();






        }
    }
}
