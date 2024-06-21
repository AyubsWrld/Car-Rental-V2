using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cmpt291UI
{
    public partial class BranchInputForm : Form
    {
        string dbForm2 = LoginScreen.databasePath;
        private int transID ; 
        private int valueINT; 
        public BranchInputForm(int transID, int valueINT)
        {
            InitializeComponent();
            this.transID = transID;
            this.valueINT = valueINT;
        }
        private void BranchInputForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void DeleteTransaction(int transID)
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

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
           int branchINFO = Convert.ToInt32(inputBox.Text);
            // Assuming "AttributeName" is the name of the column
            if (this.valueINT != branchINFO)
            {
                DialogResult result = MessageBox.Show("A fee will incur for returning to a different branch. Do you want to proceed?", "Fee Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DeleteTransaction(this.transID);
                }
                else
                {
                    this.Hide(); 
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to return?", "Return Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteTransaction(this.transID);
                }
                else 
                { 
                    this.Hide();        
                }    

            }
        }
<<<<<<< HEAD

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }
=======
>>>>>>> bfcdb7d08a947f89a48d7346eb219e9e95608961
    }
 }

