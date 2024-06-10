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

        private void ToolBarDatabaseCars(object sender, EventArgs e)
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

            MessageBox.Show("Data has been inserted, updating table");

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void SearchCarButton(object sender, EventArgs e)
        {

        }

        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            // delete vehicle here
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();

            cmd = new SqlCommand("DELETE FROM car WHERE CarVIN = '"+deleteCarVINtxt.Text+"'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data has been deleted, updating table");

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(addVehicleDBForm);
            con.Open();

            // search through database, very inefficient but works for now with a small sql
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            // insert data from extracted sql
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;

            con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteCarVINtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addCarClearButton_Click(object sender, EventArgs e)
        {
            addCarVINtxt.Clear();
            addCarTypeIDtxt.Clear();
            addCarBrandtxt.Clear();
            addCarModeltxt.Clear();
            addCarYeartxt.Clear();
            addCarColortxt.Clear();
            addCarMileagetxt.Clear();
            addCarLastTuneUptxt.Clear();
            addCarConditiontxt.Clear();
            addCarBranchLocationtxt.Clear();
        }

        private void searchCarClearButton_Click(object sender, EventArgs e)
        {
            searchCarVINtxt.Clear();
            searchCarTypeIDtxt.Clear() ;
            searchCarBrandtxt.Clear() ;
            searchCarModeltxt.Clear() ;
            searchCarYeartxt.Clear() ;
            searchCarColortxt.Clear() ;
            searchCarMileagetxt.Clear();
            searchCarLastTuneUptxt.Clear();
            searchCarConditiontxt.Clear();
            searchCarBranchLocationtxt.Clear();
        }
    }
}
