using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cmpt291UI
{
    public partial class AddNewCustomer : Form
    {
        bool firstClickDD = true;
        bool firstClickMM = true;
        bool firstClickYYYY = true;
        bool firstClickConNum = true;
        bool firstClickPostalCode = true;


        SqlCommand cmd;
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void AddNewCustomers_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox7.Clear();
            richTextBox8.Clear();
            richTextBox9.Clear();
            richTextBox10.Clear();
            textBox1.Clear();
            richTextBox23.Clear();
            richTextBox24.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check to see all textboxes are filled in


            // insert to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            // string together all the boxes for DOB insert
            string DateOfBirth = richTextBox3.Text + "-" + richTextBox23.Text + "-" + richTextBox24.Text;


            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand("INSERT INTO customers values(51, '" + richTextBox4.Text + "', " +


            //cmd = new SqlCommand("INSERT INTO customers values('" + maxCusID.ToString() + "'," +
            //" '" + richTextBox4.Text + "', " +


            " '" + richTextBox1.Text + "', " +
            " '" + richTextBox2.Text + "'," +
            " '" + DateOfBirth + "'," +
            " '" + richTextBox5.Text + "'," +
            " '" + richTextBox6.Text + "'," +
            " '" + richTextBox7.Text + "'," +
            " '" + richTextBox8.Text + "'," +
            " '" + richTextBox9.Text + "'," +
            " '" + richTextBox10.Text + "'," +
            " '" + textBox1.Text + "')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer has been inserted");

            con.Close();
        }

        private void richTextBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox24_TextChanged(object sender, EventArgs e)
        {
            if (firstClickYYYY)
            {
                richTextBox24.Text = string.Empty;
                richTextBox24.ForeColor = Color.Black;
                firstClickYYYY = false;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (firstClickDD)
            {
                richTextBox3.Text = string.Empty;
                richTextBox3.ForeColor = Color.Black;
                firstClickDD = false;
            }
        }

        private void richTextBox23_TextChanged(object sender, EventArgs e)
        {
            if (firstClickMM)
            {
                richTextBox23.Text = string.Empty;
                richTextBox23.ForeColor = Color.Black;
                firstClickMM = false;
            }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (firstClickConNum)
            {
                richTextBox5.Text = string.Empty;
                richTextBox5.ForeColor = Color.Black;
                firstClickConNum = false;
            }
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (firstClickPostalCode)
            {
                richTextBox9.Text = string.Empty;
                richTextBox9.ForeColor = Color.Black;
                firstClickPostalCode = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
