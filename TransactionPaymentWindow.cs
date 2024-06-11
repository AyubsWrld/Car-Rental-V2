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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cmpt291UI
{
    public partial class TransactionPaymentWindow : Form
    {
        SqlCommand cmd;
        public TransactionPaymentWindow()
        {
            InitializeComponent();
        }

        private void TransactionPaymentWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // insert to database
            SqlConnection con = new SqlConnection(LoginScreen.databasePath);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand("INSERT INTO RentalTransactions values('" + richTextBox17.Text + "', " +
            " '" + richTextBox18.Text + "', " +
            " '" + richTextBox11.Text + "'," +
            " '" + richTextBox12.Text + "'," +
            " '" + richTextBox19.Text + "'," +
            " '" + richTextBox20.Text + "'," +
            " '" + richTextBox5.Text + "'," +
            " '" + richTextBox21.Text + "'," +
            " '" + richTextBox22.Text + "')", con);

            MessageBox.Show("Transaction has been inserted");

            // connect to database
            TransactionsReceipt transactionReceiptForm = new TransactionsReceipt();
            transactionReceiptForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
